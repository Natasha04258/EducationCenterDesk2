using System.ComponentModel.DataAnnotations;

namespace EducationCenterApi.Models
{
        public class Oplata
    {
        public int Id { get; set; }
        public int RoditelId { get; set; }
        public int RebenokId { get; set; }
        public int KolichestvoZanyatiy { get; set; }
        public decimal Summa { get; set; }
        public string Status { get; set; } = "Не оплачено";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Данные для создания нового платежа
    /// </summary>
    public class CreateOplataRequest
    {
        /// <summary>
        /// Идентификатор родителя (плательщика)
        /// </summary>
        /// <example>1</example>
        [Required(ErrorMessage = "Укажите ID родителя")]
        public int RoditelId { get; set; }

        /// <summary>
        /// Идентификатор ребёнка (ученика)
        /// </summary>
        /// <example>2</example>
        [Required(ErrorMessage = "Укажите ID ребёнка")]
        public int RebenokId { get; set; }

        /// <summary>
        /// Количество оплачиваемых занятий (от 1 до 12)
        /// </summary>
        /// <example>8</example>
        [Range(1, 12, ErrorMessage = "Количество занятий от 1 до 12")]
        public int KolichestvoZanyatiy { get; set; }

        /// <summary>
        /// Сумма оплаты в рублях (от 500 до 100000)
        /// </summary>
        /// <example>4800</example>
        [Range(500, 100000, ErrorMessage = "Сумма от 500 до 100000")]
        public decimal Summa { get; set; }
    }

}