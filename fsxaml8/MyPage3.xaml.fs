namespace fsxaml8

open Xamarin.Forms
open Xamarin.Forms.Xaml

type MyPage3() =
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<MyPage3>)
