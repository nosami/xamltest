namespace fsxaml8

open Xamarin.Forms
open Xamarin.Forms.Xaml
type xaml = Xamarin.Forms.XamlProviders.XamlProvider<"fsxaml8Page">
type fsxaml8Page() =
    inherit ContentPage()
    //let xaml = XamlProviders.XamlTypeProvider()
    do xaml.myLabel.Text <- "Huh!?"
    //let _ = base.LoadFromXaml(typeof<fsxaml8Page>)
    //let label = base.FindByName<Label>("myLabel")
    //do label.Text <- "Huh!?"
