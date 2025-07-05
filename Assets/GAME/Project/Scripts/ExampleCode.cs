using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleCode : MonoBehaviour
{
    private const string ADS_PERSONALIZATION_CONSENT = "Ads";

    private void Start()
    {
       // Debug.Log("Terms of Service has been accepted: " + SimpleGDPR.IsTermsOfServiceAccepted);
       // Debug.Log("Ads personalization consent state: " + SimpleGDPR.GetConsentState(ADS_PERSONALIZATION_CONSENT));
       // Debug.Log("Is user possibly located in the EEA: " + SimpleGDPR.IsGDPRApplicable);
    }

    private void Update()
    {
        
    }

    private void TermsOfServiceDialogClosed()
    {
        // We can assume that user has accepted the terms because
        // TermsOfServiceDialog dialog can only be closed via the 'Accept' button
        Debug.Log("Accepted Terms of Service");
    }

    

    private void UnityAnalyticsButtonClicked()
    {
        // Fetch the URL of the page that allows the user to toggle the Unity Analytics consent
        // "Unity Data Privacy Plug-in" is required: https://assetstore.unity.com/packages/add-ons/services/unity-data-privacy-plug-in-118922
#if !UNITY_5_3_OR_NEWER && !UNITY_5_2 // Initialize must be called on Unity 5.1 or earlier
	//UnityEngine.Analytics.DataPrivacy.Initialize();
#endif
        //UnityEngine.Analytics.DataPrivacy.FetchPrivacyUrl( 
        //	( url ) => SimpleGDPR.OpenURL( url ), // On WebGL, this opens the URL in a new tab
        //	( error ) => Debug.LogError( "Couldn't fetch url: " + error ) );
    }
}