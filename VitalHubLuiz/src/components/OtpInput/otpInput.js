import { ContainerOpt, TextInputOtp } from "./style"

export const OtpInput = () => {
    return(
        <ContainerOpt>
                <TextInputOtp
                    maxLength={1}
                />
                <TextInputOtp
                    maxLength={1}
                />
                <TextInputOtp
                    maxLength={1}
                />
                <TextInputOtp
                    maxLength={1}
                />
        </ContainerOpt>
    )
}