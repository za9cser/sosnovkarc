import { MDBCol } from "mdb-react-ui-kit";
import { Desktop, Mobile } from "../../components/adaptiveMarkup";
import { AthleteModel } from "../../models/athletes/athlete";
import DesktopAthleteListitem from "./desktopAthleteListitem";
import MobileAthleteListItem from "./mobileAthleteListItem";

type Props = {
    athlete: AthleteModel;
};

function AthleteListItem({ athlete }: Props) {
    return (
        <MDBCol center>
            <Mobile>
                <MobileAthleteListItem athlete={athlete} />
            </Mobile>
            <Desktop>
                <DesktopAthleteListitem athlete={athlete} />
            </Desktop>
        </MDBCol>
    );
}

export default AthleteListItem;
