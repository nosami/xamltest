﻿namespace fsxaml8

open System
open Xamarin.Forms

type MyPage () =
    inherit ContentPage ()

    do
        let layout = StackLayout()
        layout.Children.Add(Label (Text = "Hello ContentPage"))
        base.Content <- layout
