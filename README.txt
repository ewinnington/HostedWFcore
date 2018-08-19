# Workflow foundation core (coreWF) hosted in a window service on .net core

A windows service that hosts workflow applications and executes them. This stores Workflow Activity Dlls, the workflow xaml definitions and the logs of the execution in a database. Communicates with several client applications: Console, UI, Web using SignalR. Provides a scheduler to run the workflows on a schedule and event based.

This is a work in progress, learning project. 

When code is not covered by another license, this code uses the MIT license. 

License: MIT
COPYRIGHT 2018 Eric Winnington