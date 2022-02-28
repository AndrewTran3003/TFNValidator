import React from "react";
import StatusSuccess from "./StatusSuccess";
import StatusFailure from "./StatusFailure";

function StatusIndicator(props) {
    function renderStatus()
    {
        if (props.formState === "success")
        {
            return (<StatusSuccess validationMessage={props.validationMessage} />);
        }
        if (props.formState === "error")
        {
            return (<StatusFailure validationMessage={props.validationMessage}/>);
        }
        return "";
    }


    return (
        <>
            {renderStatus()}
        </>
    );
}

export default StatusIndicator;