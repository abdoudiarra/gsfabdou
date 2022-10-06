import { Comments } from "./comments";

export interface Posts
{
  caption : string;
  liked : boolean;
  saved : boolean;
  comments : Array<Comments>;
}
