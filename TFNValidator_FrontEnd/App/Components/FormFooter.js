import React from "react";
import DialogActions from "@mui/material/DialogActions";
import ProgressIndicator from "./ProgressIndicator"
import ValidateButton from "./ValidateButton";
function FormFooter() {
    return (
        <>
            <DialogActions>
                <ProgressIndicator />
                <ValidateButton />
            </DialogActions>
        </>);
}

export default FormFooter;