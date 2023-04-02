using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Chronicle
{
    /// <summary>
    /// The main view model for this application 
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        private SideMenuControl selectedSideMenu;
        #region Public Properties

        /// <summary>
        /// Minimum width of this application 
        /// </summary>
        public double MinimumHeight { get; set; }

        /// <summary>
        /// Minimum height of this application
        /// </summary>
        public double MinimumWidth { get; set; }

        /// <summary>
        /// The current page of this application
        /// default to note
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.NoteFile;

        /// <summary>
        /// The view model to use for the current page when the Current page changes
        /// </summary>
        public BaseViewModel? CurrentPageViewModel { get; set; }

        #region Side menu

        public SideMenuControl SelectedSideMenu 
        { 
            get => selectedSideMenu;
            set
            {
               selectedSideMenu = value;
               if (ActiveSideMenu != null)
                {
                    //ActiveSideMenu
                }
            }
        }

        public SideMenuControl ActiveSideMenu { get; set; }
           

        public List<SideMenuControl> SideMenuControls { get; set; } = new List<SideMenuControl>();

        /// <summary>
        /// Side menu -> Note
        /// </summary>
        public SideMenuViewModel Note { get; set; }

        /// <summary>
        /// Side menu -> Book
        /// </summary>
        public SideMenuViewModel Book { get; set; }

        /// <summary>
        /// Side menu -> Calendar
        /// </summary>
        public SideMenuViewModel Calendar { get; set; }

        /// <summary>
        /// Side menu -> Share
        /// </summary>
        public SideMenuViewModel Share { get; set; }

        /// <summary>
        /// Side menu -> Settings
        /// </summary>
        public SideMenuViewModel Settings { get; set; }

        /// <summary>
        /// Side menu -> Trash
        /// </summary>
        public SideMenuViewModel Trash { get; set; }

        #endregion

        #endregion

        #region Public Commands


        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainViewModel()
        {
            // Set default properties
            MinimumHeight = 750;
            MinimumWidth = 1048;
            CurrentPage = ApplicationPage.NoteFile;

            // Note menu
            Note = new SideMenuViewModel(
                "Notes Menu",
                IconType.Note,
                true,
                new ObservableCollection<SubMenuDesignModel>
                {
                    new SubMenuDesignModel
                    {
                        SubMenuIcon = IconType.NotesItem,
                        FileName = "Astrophysics 101",
                    },

                    new SubMenuDesignModel
                    {
                        SubMenuIcon = IconType.NotesItem,
                        FileName = "Genesis of People and culture",
                    },

                    new SubMenuDesignModel
                    {
                        SubMenuIcon = IconType.NotesItem,
                        FileName = "The future of A.I",
                    },

                    new SubMenuDesignModel
                    {
                        SubMenuIcon = IconType.NotesItem,
                        FileName = "Beauty and the beast",
                    },

                    new SubMenuDesignModel
                    {
                        SubMenuIcon = IconType.NotesItem,
                        FileName = "The marchant ship",
                    },

                }
                );





            // Book menu

            Book = new SideMenuViewModel(
            "Books Menu",
            IconType.Book,
            true,
            new ObservableCollection<SubMenuDesignModel>
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

            }

            );

            SideMenuControls.Add(new SideMenuControl(Note, IconType.Note, true));
            SideMenuControls.Add(new SideMenuControl(Book, IconType.Book, true));
        }

        #endregion

        #region Command Methods


        #endregion

        #region Public Helpers


        public void GotoPage(ApplicationPage page)
        {
            // Sets current page value
            CurrentPage = page;

            // If page hasn't changed fire off notification to update page
            // Fire off a currentPage changed event
            OnPropertyChanged(nameof(CurrentPage));

        }

        #endregion

    }
}
