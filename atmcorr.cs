using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace espaçoGIS
{
    public partial class atmcorr : Form
    {

        public int lsCount = 42;
        public int modAeroRadioButton = 9999;
        public int magRadioButton = 9999;
        public bool txtCheck = true;
        public string[] words;
        public string dia { get; set; }
        public string mes { get; set; }
        public string landsatID { get; set; }
        public string mpfactor { get; set; }
        public string apfactor { get; set; }

        public atmcorr()
        {
            InitializeComponent();

            visib_txt.Text = "23";
            elevation_txt.Text = "elevação média";
        }

        private void carregarMTL_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT | *txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                landsat_txt.Text = ofd.FileName;
                StreamReader reader = new StreamReader(ofd.FileName);
                words = reader.ReadToEnd().Split(' ');
                findIndex(words);
                horaUniversal();
                date();
            }
        }

        private void carregarLSImg_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TIFF | *tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                landsatImg_txt.Text = ofd.FileName;
                var img = Image.FromFile(ofd.FileName);
                ntpixels_txt.Text = (img.Width * img.Height).ToString();
            }
        }

        private void criarLs_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Escolha uma pasta para salvar os arquivos de configuração.";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = @fbd.SelectedPath + "\\";
                criarArquivos(path);
            }
        }

        /// <summary>
        /// Método para buscar no metadado da imagem os valores indicados.
        /// Para coletar o valor correto em cada row, o método precisa adiciona 2 a cada index, já que estamos
        /// buscando o valor em si (value) e não o valor da chave (key).
        /// O método ainda realiza o cálculo correto do valor do zenith e preenche os campos da interface 
        /// gráfica com os valores obtidos.
        /// </summary>
        /// <param name="words"></param>
        private void findIndex(string[] words)
        {
            #region searchIndex
            // Acha o número do index da palavra - chave "LANDSAT_SCENE_ID".
            var indexLandsatID = Array.FindIndex(words, row => row.Contains("LANDSAT_SCENE_ID"));
            // Acha o número do index da palavra - chave "SUN_AZIMUTH".
            var indexAzimuth = Array.FindIndex(words, row => row.Contains("SUN_AZIMUTH"));
            // Acha o número do index da palavra-chave "SUN_ELEVATION".
            var indexElevation = Array.FindIndex(words, row => row.Contains("SUN_ELEVATION"));
            // Acha o número do index da palavra-chave "DATE_ACQUIRED".
            var indexDate = Array.FindIndex(words, row => row.Contains("DATE_ACQUIRED"));
            // Acha o número do index da palavra-chave "WRS_PATH".
            var indexPath = Array.FindIndex(words, row => row.Contains("WRS_PATH"));
            // Acha o número do index da palavra-chave "WRS_ROW".
            var indexRow = Array.FindIndex(words, row => row.Contains("WRS_ROW"));
            // Acha o número do index da palavra-chave "MAP_PROJECTION".
            var indexProjecao = Array.FindIndex(words, row => row.Contains("MAP_PROJECTION"));
            // Acha o número do index da palavra-chave "DATUM".
            var indexDatum = Array.FindIndex(words, row => row.Contains("DATUM"));
            // Acha o número do index da palavra-chave "UTM_ZONE".
            var indexZona = Array.FindIndex(words, row => row.Contains("UTM_ZONE"));
            // Acha o número do index da palavra-chave "ORIENTATION".
            var indexOrientacao = Array.FindIndex(words, row => row.Contains("ORIENTATION"));
            // Acha o número do index da palavra-chave "SCENE_CENTER_TIME".
            var indexHora = Array.FindIndex(words, row => row.Contains("SCENE_CENTER_TIME"));
            #endregion

            #region indexAdding
            // Soma 2 ao número encontrado.
            indexLandsatID = indexLandsatID + 2;
            indexAzimuth = indexAzimuth + 2;
            indexElevation = indexElevation + 2;
            indexDate = indexDate + 2;
            indexPath = indexPath + 2;
            indexRow = indexRow + 2;
            indexProjecao = indexProjecao + 2;
            indexDatum = indexDatum + 2;
            indexZona = indexZona + 2;
            indexOrientacao = indexOrientacao + 2;
            indexHora = indexHora + 2;
            #endregion

            #region Cálculo do Zenith
            // "CultureInfo.InvariantCulture" é necessário para manter o ponto de precisão do número armazenado
            double zenith = Convert.ToDouble(words[indexElevation], CultureInfo.InvariantCulture);

            // Constante Zenital = 90º (graus)
            const double zenithConst = 90.0;

            // Cálculo final: 90º menos o valor coletado no campo "SUN_AZIMUTH" 
            zenith = zenithConst - zenith;
            #endregion

            #region addFields
            // Preenche os campos com os dados coletados.
            azimuth_txt.Text = words[indexAzimuth];
            zenith_txt.Text = zenith.ToString();
            data_txt.Text = words[indexDate];
            path_txt.Text = words[indexPath];
            row_txt.Text = words[indexRow];
            proj_txt.Text = words[indexProjecao];
            datum_txt.Text = words[indexDatum];
            zona_txt.Text = words[indexZona];
            orient_txt.Text = words[indexOrientacao];
            universalTime_txt.Text = words[indexHora];
            #endregion

            // Tira as áspas do nome da imagem.
            landsatId_txt.Text = words[indexLandsatID];
            landsatID = landsatId_txt.Text;
            landsatID = landsatID.Replace(@"""", "");
            landsatId_txt.Text = landsatID;
        }

        public void MpFactor(string[] words)
        {
            var indexMpFactor = Array.FindIndex(words, row => row.Contains("RADIANCE_MULT_BAND_5"));
            indexMpFactor = indexMpFactor + 2;
            char[] numMpFactor = words[indexMpFactor].ToCharArray();

            // Divide o valor do MpFactor em duas partes. 
            // A primeira com o número em si e o segundo com o expoente.
            //string s = numMpFactor[0].ToString() 
            //    + numMpFactor[1].ToString() 
            //    + numMpFactor[2].ToString() 
            //    + numMpFactor[3].ToString() 
            //    + numMpFactor[4].ToString() 
            //    + numMpFactor[5].ToString();
            //string exp = numMpFactor[9].ToString();

            // Transformar o CharArray em String
            string MpFactorString = new string(numMpFactor);

            decimal result;

            if (!decimal.TryParse(MpFactorString, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                MessageBox.Show("Erro ao tentar converter o valor de RADIANCE_MULT_BAND_");
            }
            
            MessageBox.Show(result.ToString());
        }

        /// <summary>
        /// Carrega e transforma os valores de RADIANCE_MULT_BAND de notação científica para decimal
        /// </summary>
        /// <param name="words"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public decimal MpFactor(string[] words, int num)
        {
            var indexMpFactor = Array.FindIndex(words, row => row.Contains("RADIANCE_MULT_BAND_" + num.ToString()));
            indexMpFactor = indexMpFactor + 2;
            char[] numMpFactor = words[indexMpFactor].ToCharArray();

            // Cria uma string para alocar os valores do char array "numMpFactor"
            string MpFactorString = new string(numMpFactor);

            decimal result;

            if (!decimal.TryParse(MpFactorString, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                MessageBox.Show("Erro ao tentar converter o valor de RADIANCE_MULT_BAND_" + num.ToString());
            }

            return result;

        }

        /// <summary>
        /// Método para obter os valores de RADIANCE_ADD_BAND para todas as bandas.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public string ApFactor(string[] words, int num)
        {
            var indexApFactor = Array.FindIndex(words, row => row.Contains("RADIANCE_ADD_BAND_" + num.ToString()));
            indexApFactor = indexApFactor + 2;
            return words[indexApFactor];
        }

        private void horaUniversal()
        {
            //Criação do campo time
            //Hora + "." + ((minuto/60) + (segundo/3600)) 
            char[] timeLetters = universalTime_txt.Text.ToCharArray();
            string tempo = new string(timeLetters);
            // Seleção das variáveis
            string hora = new string(timeLetters, 0, 2);
            string minuto = tempo[3].ToString() + tempo[4].ToString();
            string segundo = tempo[6].ToString() + tempo[7].ToString();
            // Calculo para grau decimal
            double minutoUniv = Convert.ToDouble(minuto) / 60;
            double segundoUniv = Convert.ToDouble(segundo) / 3600;
            double SomaUniversalTime = Convert.ToDouble(hora) + minutoUniv + segundoUniv;
            //Mostra na tela e converte a virgula para ponto ("en-US" ou 0x0409)
            universalTime_txt.Text = SomaUniversalTime.ToString(new CultureInfo(0x0409));
        }

        private void date()
        {
            char[] dateLetters = data_txt.Text.ToCharArray();
            string data = new string(dateLetters);
            dia = data[5].ToString() + data[6].ToString();
            mes = data[8].ToString() + data[9].ToString();
            dia_txt.Text = dia;
            mes_txt.Text = mes;
        }

        private void modAero()
        {
            if (noAerosols_rdb.Checked)
            {
                modAeroRadioButton = 0;
            }
            else if (continental_rdb.Checked)
            {
                modAeroRadioButton = 1;
            }
            else if (maritime_rdb.Checked)
            {
                modAeroRadioButton = 2;
            }
            else if (urban_rdb.Checked)
            {
                modAeroRadioButton = 3;
            }
            else if (desert_rdb.Checked)
            {
                modAeroRadioButton = 5;
            }
            else if (biomass_rdb.Checked)
            {
                modAeroRadioButton = 6;
            }
            else if (stratospheric_rdb.Checked)
            {
                modAeroRadioButton = 7;
            }
            else
            {
                MessageBox.Show("É necessário escolher pelo menos um dos modelos de aerossóis disponíveis!");
            }
        }

        private void mag()
        {
            if (noGas_rdb.Checked)
            {
                magRadioButton = 0;
            }
            else if (tropical_rdb.Checked)
            {
                magRadioButton = 1;
            }
            else if (midLatSum_rdb.Checked)
            {
                magRadioButton = 2;
            }
            else if (midLatWin_rdb.Checked)
            {
                magRadioButton = 3;
            }
            else if (subArcSum_rdb.Checked)
            {
                magRadioButton = 5;
            }
            else if (subArcWin_rdb.Checked)
            {
                magRadioButton = 6;
            }
            else if (usStd_rdb.Checked)
            {
                magRadioButton = 7;
            }
            else
            {
                MessageBox.Show("É necessário escolher pelo menos um dos modelos de atmosfera gasosa disponíveis!");
            }
        }

        /// <summary>
        /// Método para criar o arquivo de configuração .inp do 6S.
        /// </summary>
        /// <param name="path"></param>
        private void criarArquivos(string path)
        {
            

            if (Directory.Exists(path))
            {
                for (int i = 1; i < 12; i++)
                {
                    mpfactor = MpFactor(words, i).ToString();
                    apfactor = ApFactor(words, i);

                    string linha1 = string.Format("  {0} {1} {2} {3} {4} (month,day,universal time,longitude,latitude)", mes, dia, zona_txt.Text.ToString(), long_txt.Text.ToString(), lat_txt.Text.ToString());
                    string linha2 = string.Format("  {0}  {1}                              (viewing zenith and azimuth in relation to the north)", zenith_txt.Text.ToString(), azimuth_txt.Text.ToString());
                    string linha3 = string.Format("  {0}                                          (tropical atmospheric model)", magRadioButton.ToString());
                    string linha4 = string.Format("  {0}                                          (urban aerosols model)", modAeroRadioButton.ToString());
                    string linha5 = string.Format("  {0}                                         (visibility in KM (aerosol model concentration))", visib_txt.Text.ToString());
                    string linha6 = string.Format("  {0}                                     (target at 50 m above sea level)", elevation_txt.Text.ToString());
                    string linha7 = string.Format("  {0}                                         (band)", lsCount.ToString());
                    string linha8 = string.Format("  {0} {1}                      (Mpfactor,Apfactor for the OLI band from metadata MTL file)", mpfactor, apfactor);
                    string linha9 = string.Format("  {0}                                   (ntpixels=total number of pixels)", ntpixels_txt.Text.ToString());

                    string FileName = "Banda" + i + "_" + ".inp";
                    var newpath = path + FileName;

                    // Cria o arquivo .inp
                    if (!File.Exists(path))
                    {
                        lsCount += 1;
                        using (StreamWriter sw = File.CreateText(newpath))
                        {
                            sw.WriteLine(linha1);
                            sw.WriteLine(linha2);
                            sw.WriteLine(linha3);
                            sw.WriteLine(linha4);
                            sw.WriteLine(linha5);
                            sw.WriteLine(linha6);
                            sw.WriteLine(linha7);
                            sw.WriteLine(linha8);
                            sw.WriteLine(linha9);
                        }
                    }
                }
            }
        }
    }
}

