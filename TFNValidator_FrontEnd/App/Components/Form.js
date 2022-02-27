import React from "react";
import Dialog from "@mui/material/Dialog";
import FormTitle from "./FormTitle";
import FormContent from "./FormContent";
import FormFooter from "./FormFooter";
import StatusIndicator from "./StatusIndicator";
    function Form ()
{
    return (
        <div>
            <Dialog open="true">
                <StatusIndicator />
                <FormTitle />
                <FormContent />
                <FormFooter />
            </Dialog>
        </div>
    );
}

export default Form;