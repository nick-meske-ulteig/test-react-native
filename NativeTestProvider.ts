import {TurboModule, TurboModuleRegistry} from 'react-native';

export interface Spec extends TurboModule {
  DoWork(message: string, callback: (result: string) => void): void;
  Add(a: number, b: number, callback: (result: number) => void): void;
}

export default TurboModuleRegistry.get<Spec>('TestProvider');
