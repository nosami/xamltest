namespace fsxaml8

open Xamarin.Forms
open Xamarin.Forms.Xaml

type fsxaml3xPage() =
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<fsxaml3xPage>)
