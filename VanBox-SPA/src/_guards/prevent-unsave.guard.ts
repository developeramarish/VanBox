import { MemberEditComponent } from './../app/members/member-edit/member-edit.component';
import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';

@Injectable()
export class PreventUnsavedChanges implements CanDeactivate<MemberEditComponent>{
    canDeactivate(component: MemberEditComponent) {
        if (component.editForm.dirty) {
            return confirm('Any unsaved change will be lost !');
        }
        return true;
    }
}
