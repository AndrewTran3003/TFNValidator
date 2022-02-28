import React from "react";
import DialogActions from "@mui/material/DialogActions";
import ProgressIndicator from "./ProgressIndicator"
import ValidateButton from "./ValidateButton";
function FormFooter(props) {
    return (
        <>
            <DialogActions>
                <ProgressIndicator />
                <ValidateButton setFormState={props.setFormState} />
            </DialogActions>
        </>);
}

export default FormFooter;