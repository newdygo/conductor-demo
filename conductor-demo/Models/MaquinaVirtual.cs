using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conductor.demo.Models
{
    /// <summary>
    /// Define o modelo da máquina virtual.
    /// </summary>
    public class MaquinaVirtual
    {
        #region Propriedades

        /// <summary>
        /// Id da máquina virtual.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da máquina virtual.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Descricao da maáquina virtual
        /// </summary>
        public string Descricao { get; set; }

        #endregion
    }
}
