namespace fsxaml8

open Xamarin.Forms
open Xamarin.Forms.Xaml
type xaml = XamlProviders.XamlProvider<"fsxaml8Page">
type fsxaml8Page() =
    inherit xaml() // xaml needs to inherit ContentPage
    do 
        base.myLabel.Text <- "Huh!?"
