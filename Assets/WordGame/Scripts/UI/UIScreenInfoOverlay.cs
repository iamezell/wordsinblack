using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScreenInfoOverlay : UIScreen
{

    #region Inspector Variables

    [SerializeField]
    private Image categoryIconImage;
    [SerializeField]
    private Text categoryNameText;
    [SerializeField]
    private Text categoryLevelText;
    [SerializeField]
    private GameObject plusOneHintText;

    #endregion

    #region Member Variables
    #endregion

    #region Properties
    #endregion

    #region Unity Methods
    #endregion

    #region Public Methods

    public override void OnShowing(object data)
    {
        // CategoryInfo categoryInfo = GameManager.Instance.GetCategoryInfo(GameManager.Instance.ActiveCategory);

        // categoryIconImage.sprite = categoryInfo.icon;
        // categoryNameText.text = GameManager.Instance.ActiveCategory;

        // if (GameManager.Instance.ActiveCategory == GameManager.dailyPuzzleId)
        // {
        //    categoryLevelText.gameObject.SetActive(false);
        // }
        // else
        // {
        //    categoryLevelText.gameObject.SetActive(true);
        //    categoryLevelText.text = "Level " + (GameManager.Instance.ActiveLevelIndex + 1).ToString();
        // }

        // plusOneHintText.SetActive((bool)data);

        categoryNameText.text = "Hello Nurse";

    }

    public void OnBackClicked()
    {
        // Go back to main screen
        UIScreenController.Instance.HideOverlay(UIScreenController.ClueScreenId, true, Tween.TweenStyle.EaseOut);
    }

    #endregion

    #region Protected Methods
    #endregion

    #region Private Methods
    #endregion
}
