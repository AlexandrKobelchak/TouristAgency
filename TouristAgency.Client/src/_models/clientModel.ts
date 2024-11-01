import {Guid} from 'guid-typescript';
import {IModel} from '../_abstaract/IModel';
import {TagViewModel} from './clientTagViewModel'
import {ClientPhoneModel} from "./clientPhoneModel";

export class ClientModel implements IModel{

    public id: Guid | undefined ;
    public firstName: string | undefined;
    public middleName: string | undefined;
    public lastName: string | undefined;
    public phones: ClientPhoneModel[] | undefined;
    public touristTags: TagViewModel[] | undefined;
}
