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
    const [validationMessage, setValidationMessage] = useState("");
    function setFormState(state)
    {
        console.log("called");
        setState(state);
    }
    return (
        <div>
            <Dialog open="true">
                <StatusIndicator formState={formState} validationMessage={validationMessage}/>
                <FormTitle />
                <FormContent formState ={formState} setInputValue={setInputValue} />
                <FormFooter formState={formState} setFormState={setFormState} inputValue={inputValue} setValidationMessage={setValidationMessage}/>
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