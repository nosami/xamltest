namespace fsxaml8
open System
open Xamarin.Forms
open Xamarin.Forms.Xaml

type XamlPageBase = XAML<"XamlPage">

type XamlPage() =
    inherit XamlPageBase()

    do
        base.myLabel.Text <- "It Works!?"
