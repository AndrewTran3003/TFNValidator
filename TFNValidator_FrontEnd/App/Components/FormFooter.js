import React from "react";
import DialogActions from "@mui/material/DialogActions";
import ProgressIndicator from "./ProgressIndicator"
import ValidateButton from "./ValidateButton";
function FormFooter(props) {
    return (
        <>
            <DialogActions>
                <ProgressIndicator formState={props.formState} />
                <ValidateButton setFormState={props.setFormState} inputValue={props.inputValue} setValidationMessage={props.setValidationMessage}/>
            </DialogActions>
        </>);
}

export default FormFooter;