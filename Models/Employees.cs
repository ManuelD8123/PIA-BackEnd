namespace PIA_BackEnd.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            Employees1 = new HashSet<Employees>();
            Orders = new HashSet<Orders>();
            Territories = new HashSet<Territories>();
        }
        /// <summary>
        /// Id del Empleado
        /// </summary>
        [Key] //Se especifica que es la llave primaria
        public int EmployeeID { get; set; }

        /// <summary>
        /// Apellido del Empleado
        /// </summary>
        [Required] //No puede ser nula
        [StringLength(20)] //Especificamos la Longitud
        public string LastName { get; set; }

        /// <summary>
        /// Nombre del Empleado
        /// </summary>
        [Required] //No puede ser nula
        [StringLength(10)] //Longitud de la cadena
        public string FirstName { get; set; }

        [StringLength(30)] //Longitud de la cadena
        public string Title { get; set; }

        [StringLength(25)] //Longitud de la cadena
        public string TitleOfCourtesy { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        [StringLength(60)] //Longitud de la cadena
        public string Address { get; set; }

        [StringLength(15)] //Longitud de la cadena
        public string City { get; set; }

        [StringLength(15)] //Longitud de la cadena
        public string Region { get; set; }

        [StringLength(10)] //Longitud de la cadena
        public string PostalCode { get; set; }

        [StringLength(15)] //Longitud de la cadena
        public string Country { get; set; }

        [StringLength(24)] //Longitud de la cadena
        public string HomePhone { get; set; }

        [StringLength(4)] //Longitud de la cadena
        public string Extension { get; set; }

        [JsonIgnore] //Le decimos al que al solicitar la creacion de un JSON se omita este campo
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        [JsonIgnore]
        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int? ReportsTo { get; set; }

        [StringLength(255)]
        public string PhotoPath { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employees> Employees1 { get; set; }

        [JsonIgnore]
        public virtual Employees Employees2 { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Territories> Territories { get; set; }
    }
}
