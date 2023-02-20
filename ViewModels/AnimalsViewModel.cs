using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiGrouping.Models;
using CommunityToolkit.Mvvm.Input;

namespace MauiGrouping.ViewModels
{
    public partial class AnimalsViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<AnimalList> allAnimals;
        public AnimalsViewModel() { }

        // This is a little convoluted but the data needs to be entered in a constructor
        // not sure why, but it works
        public void LoadData()
        {
            // initialize list
            AllAnimals = new ObservableCollection<AnimalList>();

            // first create a list of all animals to be inserted into the observableCollection
            // for example purposes only, you'll be importing data from other means
            List<Animal> bears = new List<Animal>();
            List<Animal> monkeys = new List<Animal>();

            monkeys.Add(new Animal
            {
                name = "Mandrill",
                location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                details = "The mandrill is a primate of the Old World Animal family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo."
            });

            monkeys.Add(new Animal
            {
                name = "Proboscis Animal",
                location = "Borneo",
                details = "The proboscis Animal or long-nosed Animal, known as the bekantan in Malay, is a reddish-brown arboreal Old World Animal that is endemic to the south-east Asian island of Borneo."
            });

            monkeys.Add(new Animal
            {
                name = "Red-shanked Douc",
                location = "Vietnam, Laos",
                details = "The red-shanked douc is a species of Old World Animal, among the most colourful of all primates. This Animal is sometimes called the \"costumed ape\" for its extravagant appearance. From its knees to its ankles it sports maroon-red \"stockings\", and it appears to wear white forearm length gloves. Its attire is finished with black hands and feet. The golden face is framed by a white ruff, which is considerably fluffier in males. The eyelids are a soft powder blue. The tail is white with a triangle of white hair at the base. Males of all ages have a white spot on both sides of the corners of the rump patch, and red and white genitals."
            });

            bears.Add(new Animal
            {
                name = "Black",
                location = "North America",
                details = "The black bear is a shy and native bear in North America"
            });

            bears.Add(new Animal
            {
                name = "Polar",
                location = "Canada",
                details = "The polar bear is one of the largest bears on the planet."
            });

            // now we insert this information into the observable list here
            // again, this is messy, but it's to demo the groupings
            AnimalList allMonkeys = new AnimalList("Monkeys", monkeys);
            AnimalList allBears = new AnimalList("Bears", bears);

            // note the capital letter starting the variable here
            AllAnimals.Add(allMonkeys);
            AllAnimals.Add(allBears);

        }

        [RelayCommand]
        public void Expand(AnimalList arg)
        {
            arg.IsExpanded = !arg.IsExpanded;  // flip / flop buttons
            arg.NotExpanded = !arg.NotExpanded;
        }
    }
}
