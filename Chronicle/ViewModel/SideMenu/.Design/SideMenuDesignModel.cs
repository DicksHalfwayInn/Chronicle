using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronicle
{
    /// <summary>
    /// Design-model for <see cref="SideMenuControl"/>
    /// </summary>
    public class SideMenuDesignModel : SideMenuViewModel
    {
        /// <summary>
        /// Single instance of this class
        /// </summary>
        public static SideMenuDesignModel Instance = new SideMenuDesignModel();

        /// <summary>
        /// Default constructor
        /// </summary>
        public SideMenuDesignModel()
        {

            // Sub-menu
            SubMenu = new ObservableCollection<SubMenuDesignModel>
            {
                new SubMenuDesignModel
                {
                    SubMenuIcon = IconType.BooksItem,
                    FileName = "Astrophysics 101",
                },
                
                new SubMenuDesignModel
                {
                    SubMenuIcon = IconType.BooksItem,
                    FileName = "Genesis of People and culture",
                },

                new SubMenuDesignModel
                {
                    SubMenuIcon = IconType.BooksItem,
                    FileName = "The future of A.I",
                },

                new SubMenuDesignModel
                {
                    SubMenuIcon = IconType.BooksItem,
                    FileName = "Beauty and the beast",
                },

                new SubMenuDesignModel
                {
                    SubMenuIcon = IconType.BooksItem,
                    FileName = "The marchant ship",
                },

            };
        }
    }
}
