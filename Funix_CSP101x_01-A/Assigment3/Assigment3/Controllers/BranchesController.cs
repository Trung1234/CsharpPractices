using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assigment3.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace Assigment3.Controllers
{
    /// <summary>
    /// lớp xử lý logic của bảng Branch
    /// </summary>
    public class BranchesController : Controller
    {
        /// <summary>
        /// Biến lấy đường dẫn hienj tại của file Data
        /// </summary>
        private string currentPath = string.Empty;
        private IHostingEnvironment _hostingEnvironment;

        public BranchesController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            currentPath = _hostingEnvironment.ContentRootPath+"\\Data\\branch.json";
            // Kiểm tra nếu chưa tồn tại file json
            if (!System.IO.File.Exists(currentPath))
            {
                System.IO.File.Create(currentPath).Close();
                var newContent = new List<Branch>();
                System.IO.File.WriteAllText(currentPath, JsonConvert.SerializeObject(newContent, Formatting.Indented));
            }
        }

        /// <summary>
        /// GET: Branches
        /// Hàm lấy danh sách giá trị branch trong file branch.json
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var json = System.IO.File.ReadAllText(currentPath);
            if (!string.IsNullOrEmpty(json.Trim()))
            {
                var branches = JsonConvert.DeserializeObject<List<Branch>>(json);
                if (branches == null) branches = new List<Branch>();
                return View(branches);
            }
            else
            {
                return RedirectToAction(nameof(Create));
            }
        }

        // GET: Branches/Details/5
        public IActionResult Details(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }
                var branch = GetCurrentBranch((int)id);
                if (branch == null)
                {
                    return NotFound();
                }
                return View(branch);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }          
        }

        /// <summary>
        /// UI cho chức năng thêm mới
        /// GET: Branches/Create
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Gửi data để ghi xuống file branch.json
        /// POST: Branches/Create
        /// </summary>
        /// <param name="branch"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("BranchId,Name,Address,City,State,ZipCode")] Branch branch)
        {
            if (branch != null)
            {
                try
                {
                    var json = System.IO.File.ReadAllText(currentPath);
                    var currentBranch = JsonConvert.DeserializeObject<List<Branch>>(json);
                    if (currentBranch == null) currentBranch = new List<Branch>();
                    currentBranch.Add(branch);
                    System.IO.File.WriteAllText(currentPath, JsonConvert.SerializeObject(currentBranch, Formatting.Indented));
                }
                catch
                {
                    return RedirectToAction("Error", "Home");
                }
            }
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Hiển thị giá trị đã lấy được 
        /// GET: Branches/Edit/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }
                var branch = GetCurrentBranch((int)id);
                if (branch == null)
                {
                    return NotFound();
                }
                return View(branch);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        /// <summary>
        /// POST: Branches/Edit/5
        /// Gửi data để ghi xuống file branch.json
        /// </summary>
        /// <param name="id"></param>
        /// <param name="branch"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("BranchId,Name,Address,City,State,ZipCode")] Branch branch)
        {
            try
            {
                if (id != branch.BranchId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    var json = System.IO.File.ReadAllText(currentPath);
                    var currentBranchList = JsonConvert.DeserializeObject<List<Branch>>(json);
                    for (int i = 0; i < currentBranchList.Count; i++)
                    {
                        if (currentBranchList[i].BranchId == branch.BranchId)
                        {
                            currentBranchList[i].Address = branch.Address;
                            currentBranchList[i].City = branch.City;
                            currentBranchList[i].State = branch.State;
                            currentBranchList[i].Name = branch.Name;
                            currentBranchList[i].ZipCode = branch.ZipCode;
                        }
                    }
                    System.IO.File.WriteAllText(currentPath, JsonConvert.SerializeObject(currentBranchList));
                    return RedirectToAction(nameof(Index));
                }
                return View(branch);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: Branches/Delete/5
        public IActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }
                var branch = GetCurrentBranch((int)id);
                if (branch == null)
                {
                    return NotFound();
                }
                return View(branch);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: Branches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                var json = System.IO.File.ReadAllText(currentPath);
                List<Branch> currentBranchList = JsonConvert.DeserializeObject<List<Branch>>(json);
                var branch = currentBranchList.FirstOrDefault(m => m.BranchId == id);
                currentBranchList.Remove(branch);
                System.IO.File.WriteAllText(currentPath, JsonConvert.SerializeObject(currentBranchList));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        /// <summary>
        /// Lấy ra branch trong file json theo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Branch GetCurrentBranch(int id)
        {
            var json = System.IO.File.ReadAllText(currentPath);
            List<Branch> currentBranchList = JsonConvert.DeserializeObject<List<Branch>>(json);
            var branch = currentBranchList.FirstOrDefault(m => m.BranchId == id);
            return branch;
        }
    }
}
