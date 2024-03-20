import styled from 'styled-components'

export const LinkMedium = styled.Text`
    font-size: 14px;
    font-family: MontserratAlternates_500Medium;
    color: #8c8a97;
    margin-top: 10px;
    margin-bottom: 15px;
    align-self: flex-start;
    margin-left: 20px;
    text-decoration: underline;
`

export const LinkBold = styled.Text`
    font-family: MontserratAlternates_600SemiBold;
    font-size: 14px;
    color: #4D659D;
    text-decoration: underline;
`

export const LinkCancel = styled(LinkBold)`
    color: #344F8F;
`

export const LinkCancelProfile = styled(LinkBold)`
    color: #C81D25;
`
