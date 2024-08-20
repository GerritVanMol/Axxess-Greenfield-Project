# The Greenfield Project

## Prerequisites

This project is written in **CSharp**. The application can be shipped using **Docker**.

## Running

Run the application using `docker run -p 8080:8080 greenfield-project`.

## The Goal

Deploy the application as a web service reachable from the internet. You can use all resources available on Azure, but **everything has to be provisioned through Infrastructure as Code**. You can use Bicep, Terraform or a tool of your own choice.

We will took at 4 pillars when reviewing the application

### Operational Excellence

How easy is it to deploy new changes and how easy is it for developers to troubleshoot the application. 

### Performance and Cost

How well is the workload scaled for tasks it needs to perform.

### Security

How is security handled on infrastructure level. Which ports are reachable? Which permissions does the application get? Which actions can I perform as the application?

### Reliability

Is the application built to scale and to recover from failures?