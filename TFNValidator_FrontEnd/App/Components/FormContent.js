import React from 'react';
import DialogContent from "@mui/material/DialogContent";
import Label from "./Label";
import Input from "./Input";

function FormContent(props) {
    return (
        <>
            <DialogContent >
                <Label />
                <Input formState={props.formState} setInputValue = {props.setInputValue}/>
            </DialogContent>
        </>

    );
}
export default FormContent;