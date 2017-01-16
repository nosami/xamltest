namespace fsxaml8

open System

open Xamarin.Forms
open Xamarin.Forms.Xaml

type MyPage1() =
    inherit ContentPage ()
    let _ = base.LoadFromXaml(typeof<MyPage1>)


