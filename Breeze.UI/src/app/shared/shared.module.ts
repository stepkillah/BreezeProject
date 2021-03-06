import { NgModule, ModuleWithProviders } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoinNotationPipe } from './pipes/coin-notation.pipe';
import { AutoFocusDirective } from './directives/auto-focus.directive';
import { PasswordValidationDirective } from './directives/password-validation.directive';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  imports: [CommonModule, HttpClientModule],
  declarations: [CoinNotationPipe, AutoFocusDirective, PasswordValidationDirective],
  exports: [CoinNotationPipe, AutoFocusDirective]
})

export class SharedModule {
  static forRoot(): ModuleWithProviders {
    return {
      ngModule: SharedModule,
      providers: []
    };
  }
}
