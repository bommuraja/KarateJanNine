using BL_Karate;
using BL_Karate.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateJanNine.ViewModels
{
    public class PhotoDetailsVM
    {
        private List<PhotoDetailsDM> PhotoDetailsDMList;
        private BusinessLayer businessLayer;
        public PhotoDetailsVM() 
        { 
        
        }
        public PhotoDetailsVM(BusinessLayer BusinessLayer)
        {
            businessLayer = BusinessLayer;
        }
        public int Id { get; set; }
        public string UniqueName { get; set; }
        public string ModuleName { get; set; }
        public string FolderName { get; set; }
        public string FolderPath { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string OptionOne { get; set; }

        public List<PhotoDetailsVM> GetPhotoDetailsVM()
        {
            var PhotoDetailsVMList = new List<PhotoDetailsVM>();
            var PhotoDetailsDMList = businessLayer.GetPhotoDetailsDM();
            foreach (var PhotoDetailsDM in PhotoDetailsDMList)
            {
                var PhotoDetailsVM = new PhotoDetailsVM
                {
                    Id = PhotoDetailsDM.Id,
                    UniqueName = PhotoDetailsDM.UniqueName,
                    ModuleName = PhotoDetailsDM.ModuleName,
                    FolderName = PhotoDetailsDM.FolderName,
                    FolderPath = PhotoDetailsDM.FolderPath,
                    Name = PhotoDetailsDM.Name,
                    Title = PhotoDetailsDM.Title,
                    Description = PhotoDetailsDM.Description,
                    Comments = PhotoDetailsDM.Comments,
                    OptionOne = PhotoDetailsDM.OptionOne
                };
                PhotoDetailsVMList.Add(PhotoDetailsVM);
            }
            return PhotoDetailsVMList;
        }
    }
}
