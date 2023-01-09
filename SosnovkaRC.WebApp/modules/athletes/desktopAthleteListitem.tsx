import { faUser } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { MDBRow } from "mdb-react-ui-kit";
import { AthleteModel } from "../../models/athletes/athlete";

type Props = {
    athlete: AthleteModel;
};

const DesktopAthleteListitem = ({ athlete }: Props) => {
    return (
        <div className="pt-1 border rounded hover-shadow">
            <MDBRow center>
                <FontAwesomeIcon icon={faUser} size="10x" />
            </MDBRow>
            <MDBRow center>{athlete.firstName}</MDBRow>
            <MDBRow center>{athlete.lastName}</MDBRow>
        </div>
    );
};

export default DesktopAthleteListitem;
