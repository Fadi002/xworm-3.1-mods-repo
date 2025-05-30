using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xpepemod;
namespace downloader
{
    public class entry : IMod
    {
        public void OnLoad()
        {
            Xpepemod.Xpepemod.Log.Info("Downloader generator loaded.");

            Xpepemod.Xpepemod.Events.AddFeature("p00032e", "Downloader", () =>
            {
                Downloader form = new Downloader();
                form.ShowDialog();
            }, icon: Resource.download, tooltip: "Generate downloader");

        }
        }
}
