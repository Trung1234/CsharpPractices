using System;
using System.Collections.Generic;

namespace Assigment3.Models
{
    /// <summary>
    /// Đối tượng quản lý danh mục chi nhánh
    /// </summary>
    public partial class Branch
    {
        /// <summary>
        /// Mã chi nhánh
        /// </summary>
        public int BranchId { get; set; }
        /// <summary>
        /// Tên chi nhánh
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Thành phố
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Trạng thái
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Mã Zip
        /// </summary>
        public string ZipCode { get; set; }
    }
}
