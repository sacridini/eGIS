using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotSpatial.Controls;

namespace espaçoGIS
{
    public partial class espaço : Form
    {

        public espaço()
        {
            InitializeComponent();
        }

        #region Botões Básicos
        /// <summary>
        /// Botão Adicionar Camada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void carregar_btn_Click(object sender, EventArgs e)
        {
            map1.AddLayer();
            map1.FunctionMode = FunctionMode.Pan;
        }

        /// <summary>
        /// Botão Zoom In
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomIn_btn_Click(object sender, EventArgs e)
        {
            map1.ZoomIn();
        }

        /// <summary>
        /// Botão Zoom Out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomOut_btn_Click(object sender, EventArgs e)
        {
            map1.ZoomOut();
        }

        /// <summary>
        /// Botão Zoom To Extent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomToExtent_btn_Click(object sender, EventArgs e)
        {
            map1.ZoomToMaxExtent();
        }

        /// <summary>
        /// Botão Limpar Camadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearLayers_btn_Click(object sender, EventArgs e)
        {
            map1.ClearLayers();
        }

        /// <summary>
        /// Botão Informações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Info_btn_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.Info;
        }

        /// <summary>
        /// Botão Pan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pan_btn_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.Pan;
        }

        /// <summary>
        /// Botão Salvar Camada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Salvar_btn_Click(object sender, EventArgs e)
        {
            map1.SaveLayer();
        }

        /// <summary>
        /// Botão Selecionar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seleção_btn_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.Select;
        }
        #endregion
    }
}
