
# react-native-nlp

## Getting started

`$ npm install react-native-nlp --save`

### Mostly automatic installation

`$ react-native link react-native-nlp`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-nlp` and add `RNNlp.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNNlp.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNNlpPackage;` to the imports at the top of the file
  - Add `new RNNlpPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-nlp'
  	project(':react-native-nlp').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-nlp/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-nlp')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNNlp.sln` in `node_modules/react-native-nlp/windows/RNNlp.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Nlp.RNNlp;` to the usings at the top of the file
  - Add `new RNNlpPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNNlp from 'react-native-nlp';

// TODO: What to do with the module?
RNNlp;
```
  