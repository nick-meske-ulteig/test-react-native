# Getting Started

Install the dependencies for your development machine outlined here: [React Native for Windows Environment Setup](https://microsoft.github.io/react-native-windows/docs/rnw-dependencies)

> Note: I had to use the manual setup instructions at first to get React Native running. 

## Step 1: Start the Server

In the base directory, run the command `npm run start`
This will build the C# modules AND the react components into one working directory and will launch the emulator.

## Step 2: Modifying The App

App.tsx in the root folder contains the intial components for the UX. All there is for now is the boilerplate code that came with React Native AND some code I use to implment two textboxes with numbers that call into our backend c# code to add the numbers and return the value back to the frontend.

The `windows` folder contains all the C# code. Navigate to `windows/Rn2/MyProjectStuff` to find the test provider I was working with.

## Step 3: Familiarize yourself with React Native
[Getting Started React Native](https://reactnative.dev/docs/getting-started)

[Getting Started React Native for Windows](https://microsoft.github.io/react-native-windows/docs/getting-started)

### Items to still figure out
- Is there an easier way to pull the c# module into React Native frontend? Right now we essentially mimic the same interface on the frontend as we do in the backend. See `NativeTestProvider.ts` for those details. 

# Troubleshooting

If you can't get this to work, see the [Troubleshooting](https://reactnative.dev/docs/troubleshooting) page.

# Learn More

To learn more about React Native, take a look at the following resources:

- [React Native Website](https://reactnative.dev) - learn more about React Native.
- [Getting Started](https://reactnative.dev/docs/environment-setup) - an **overview** of React Native and how setup your environment.
- [Learn the Basics](https://reactnative.dev/docs/getting-started) - a **guided tour** of the React Native **basics**.
- [Blog](https://reactnative.dev/blog) - read the latest official React Native **Blog** posts.
- [`@facebook/react-native`](https://github.com/facebook/react-native) - the Open Source; GitHub **repository** for React Native.

This is a new [**React Native**](https://reactnative.dev) project, bootstrapped using [`@react-native-community/cli`](https://github.com/react-native-community/cli).


```

```
