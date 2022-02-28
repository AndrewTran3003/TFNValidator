import React,{useState} from "react";
import Dialog from "@mui/material/Dialog";
import FormTitle from "./FormTitle";
import FormContent from "./FormContent";
import FormFooter from "./FormFooter";
import StatusIndicator from "./StatusIndicator";

function Form()
{
    const [formState, setState] = useState(new FormState("active"));
    const [inputValue, setInputValue] = useState("");
    function setFormState(state)
    {
        console.log("called");
        setState(state);
    }
    return (
        <div>
            <Dialog open="true">
                <StatusIndicator />
                <FormTitle />
                <FormContent formState ={formState} setInputValue={setInputValue} />
                <FormFooter setFormState={setFormState} inputValue ={inputValue}/>
            </Dialog>
        </div>
    );
}

class FormState
{
    constructor(status)
    {
        this.status = status;
    }
}

export default Form;