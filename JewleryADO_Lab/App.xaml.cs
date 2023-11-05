using AutoMapper;
using DesignProjectsManagementStudio.Mappers;
using JewleryADO_Lab.ViewModels;
using Persistance;
using System.Windows;

namespace JewleryADO_Lab
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ApplicationContext _context;
        private readonly ContextViewModel _contextViewModel;
        private readonly IMapper _mapper;

        public App()
        {
            _context = new ApplicationContext();
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.AddProfiles(new Profile[]
                {
                    new MapperProfile()
                });
                cfg.AllowNullCollections = true;
            }));

            _contextViewModel = new ContextViewModel(_mapper, _context);

            var window = new MainWindow(_contextViewModel, _mapper);
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _context.SaveChanges();
            base.OnExit(e);
        }




    }
}
