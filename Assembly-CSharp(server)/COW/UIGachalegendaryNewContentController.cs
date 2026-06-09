using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020017EF RID: 6127
	[Token(Token = "0x20017EF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F31A4", Offset = "0x10F31A4")]
	public class UIGachalegendaryNewContentController : UIGachaContentBase, IUIModelDataChangeObserver
	{
		// Token: 0x060076B9 RID: 30393 RVA: 0x00020E08 File Offset: 0x0001F008
		[Token(Token = "0x60076B9")]
		[Address(RVA = "0x1FB3EA8", Offset = "0x1FB3EA8", VA = "0x7BBC7B3EA8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BA")]
		[Address(RVA = "0x1FB3EF8", Offset = "0x1FB3EF8", VA = "0x7BBC7B3EF8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BB")]
		[Address(RVA = "0x1FB48C4", Offset = "0x1FB48C4", VA = "0x7BBC7B48C4", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BC")]
		[Address(RVA = "0x1FB4CEC", Offset = "0x1FB4CEC", VA = "0x7BBC7B4CEC", Slot = "22")]
		public override void Hide()
		{
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x00020E20 File Offset: 0x0001F020
		[Token(Token = "0x60076BD")]
		[Address(RVA = "0x1FB4CF4", Offset = "0x1FB4CF4", VA = "0x7BBC7B4CF4", Slot = "43")]
		public override Vector3 GetAvatarPos()
		{
			return default(Vector3);
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BE")]
		[Address(RVA = "0x1FB4D40", Offset = "0x1FB4D40", VA = "0x7BBC7B4D40", Slot = "38")]
		public override void OnSkipAnim()
		{
		}

		// Token: 0x060076BF RID: 30399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BF")]
		[Address(RVA = "0x1FB43D0", Offset = "0x1FB43D0", VA = "0x7BBC7B43D0")]
		private void SetInitialState()
		{
		}

		// Token: 0x060076C0 RID: 30400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C0")]
		[Address(RVA = "0x1FB557C", Offset = "0x1FB557C", VA = "0x7BBC7B557C")]
		private void OnLegendAnimPopEnd(params object[] data)
		{
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C1")]
		[Address(RVA = "0x1FB5654", Offset = "0x1FB5654", VA = "0x7BBC7B5654", Slot = "30")]
		protected override void InitGachaContentBuyBtn()
		{
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C2")]
		[Address(RVA = "0x1FB5834", Offset = "0x1FB5834", VA = "0x7BBC7B5834")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x060076C3 RID: 30403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C3")]
		[Address(RVA = "0x1FB5A20", Offset = "0x1FB5A20", VA = "0x7BBC7B5A20")]
		private void ShowBubble()
		{
		}

		// Token: 0x060076C4 RID: 30404 RVA: 0x00020E38 File Offset: 0x0001F038
		[Token(Token = "0x60076C4")]
		[Address(RVA = "0x1FB5C04", Offset = "0x1FB5C04", VA = "0x7BBC7B5C04")]
		private bool HasSpecialToken()
		{
			return default(bool);
		}

		// Token: 0x060076C5 RID: 30405 RVA: 0x00020E50 File Offset: 0x0001F050
		[Token(Token = "0x60076C5")]
		[Address(RVA = "0x1FB5C18", Offset = "0x1FB5C18", VA = "0x7BBC7B5C18")]
		private bool OnlyHasSpecialToken()
		{
			return default(bool);
		}

		// Token: 0x060076C6 RID: 30406 RVA: 0x00020E68 File Offset: 0x0001F068
		[Token(Token = "0x60076C6")]
		[Address(RVA = "0x1FB5C2C", Offset = "0x1FB5C2C", VA = "0x7BBC7B5C2C")]
		private bool HasSpecialTokenMoreThanOne()
		{
			return default(bool);
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C7")]
		[Address(RVA = "0x1FB5C40", Offset = "0x1FB5C40", VA = "0x7BBC7B5C40", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C8")]
		[Address(RVA = "0x1FB5CF4", Offset = "0x1FB5CF4", VA = "0x7BBC7B5CF4")]
		public void PlayLengendaryAnim(string anim)
		{
		}

		// Token: 0x060076C9 RID: 30409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C9")]
		[Address(RVA = "0x1FB5D3C", Offset = "0x1FB5D3C", VA = "0x7BBC7B5D3C")]
		private void RefreshProgressValue()
		{
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076CA")]
		[Address(RVA = "0x1FB6000", Offset = "0x1FB6000", VA = "0x7BBC7B6000")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1141AA4", Offset = "0x1141AA4")]
		private IEnumerator PlayProgressAnim(int startPoint, int endPoint)
		{
			return null;
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CB")]
		[Address(RVA = "0x1FB4588", Offset = "0x1FB4588", VA = "0x7BBC7B4588")]
		private void SetProgressBarValue(float value)
		{
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CC")]
		[Address(RVA = "0x1FB60DC", Offset = "0x1FB60DC", VA = "0x7BBC7B60DC")]
		private void OnPreviewClothBtnClick()
		{
		}

		// Token: 0x060076CD RID: 30413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CD")]
		[Address(RVA = "0x1FB6244", Offset = "0x1FB6244", VA = "0x7BBC7B6244")]
		private void OnBagBtnClick()
		{
		}

		// Token: 0x060076CE RID: 30414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CE")]
		[Address(RVA = "0x1FB64F4", Offset = "0x1FB64F4", VA = "0x7BBC7B64F4")]
		private void RefreshBagNum(bool hasDraw = false)
		{
		}

		// Token: 0x060076CF RID: 30415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CF")]
		[Address(RVA = "0x1FB65CC", Offset = "0x1FB65CC", VA = "0x7BBC7B65CC")]
		private void OnBagBtnClickEvent(params object[] data)
		{
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D0")]
		[Address(RVA = "0x1FB65D0", Offset = "0x1FB65D0", VA = "0x7BBC7B65D0")]
		private void OnLuckProgressClick()
		{
		}

		// Token: 0x060076D1 RID: 30417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D1")]
		[Address(RVA = "0x1FB680C", Offset = "0x1FB680C", VA = "0x7BBC7B680C")]
		private void RefreshCountDownLabel()
		{
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D2")]
		[Address(RVA = "0x1FB692C", Offset = "0x1FB692C", VA = "0x7BBC7B692C")]
		private void RefreshTokenNum()
		{
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D3")]
		[Address(RVA = "0x1FB6CB8", Offset = "0x1FB6CB8", VA = "0x7BBC7B6CB8")]
		private void RefreshTokenSprite()
		{
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D4")]
		[Address(RVA = "0x1FB6FB8", Offset = "0x1FB6FB8", VA = "0x7BBC7B6FB8")]
		private void RefreshProgressBarValueOnShowContent()
		{
		}

		// Token: 0x060076D5 RID: 30421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D5")]
		[Address(RVA = "0x1FB711C", Offset = "0x1FB711C", VA = "0x7BBC7B711C")]
		private void RefreshStyle()
		{
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D6")]
		[Address(RVA = "0x1FB7478", Offset = "0x1FB7478", VA = "0x7BBC7B7478")]
		public void SetCDNTitle()
		{
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D7")]
		[Address(RVA = "0x1FB7578", Offset = "0x1FB7578", VA = "0x7BBC7B7578")]
		public void OnClickRewardPoolBtn()
		{
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D8")]
		[Address(RVA = "0x1FB763C", Offset = "0x1FB763C", VA = "0x7BBC7B763C", Slot = "44")]
		public override void GetPreviewSceneBorder(uint gachaID, out Vector3 left, out Vector3 right)
		{
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D9")]
		[Address(RVA = "0x1FB7758", Offset = "0x1FB7758", VA = "0x7BBC7B7758", Slot = "37")]
		public override void OnPurchaseResult(bool isSuccess)
		{
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076DA")]
		[Address(RVA = "0x1FB7F58", Offset = "0x1FB7F58", VA = "0x7BBC7B7F58", Slot = "31")]
		protected override void OnRefreshUIView()
		{
		}

		// Token: 0x060076DB RID: 30427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076DB")]
		[Address(RVA = "0x1FB84D4", Offset = "0x1FB84D4", VA = "0x7BBC7B84D4", Slot = "34")]
		public override void OnHideContent()
		{
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076DC")]
		[Address(RVA = "0x1FB8894", Offset = "0x1FB8894", VA = "0x7BBC7B8894", Slot = "35")]
		public override void OnShowContent()
		{
		}

		// Token: 0x060076DD RID: 30429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076DD")]
		[Address(RVA = "0x1FB50F8", Offset = "0x1FB50F8", VA = "0x7BBC7B50F8")]
		public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
		{
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076DE")]
		[Address(RVA = "0x1FB8D98", Offset = "0x1FB8D98", VA = "0x7BBC7B8D98")]
		private void ShowExchangeResultWnd(params object[] data)
		{
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076DF")]
		[Address(RVA = "0x1FB91D8", Offset = "0x1FB91D8", VA = "0x7BBC7B91D8")]
		private void OnCloseCommonRewardWindow(params object[] param)
		{
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E0")]
		[Address(RVA = "0x1FB9520", Offset = "0x1FB9520", VA = "0x7BBC7B9520")]
		private void OnItemBagPackClose(params object[] param)
		{
		}

		// Token: 0x060076E1 RID: 30433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E1")]
		[Address(RVA = "0x1FB94CC", Offset = "0x1FB94CC", VA = "0x7BBC7B94CC")]
		private void ResetInfoState()
		{
		}

		// Token: 0x060076E2 RID: 30434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E2")]
		[Address(RVA = "0x1FB947C", Offset = "0x1FB947C", VA = "0x7BBC7B947C")]
		private void ShowTokenVfx()
		{
		}

		// Token: 0x060076E3 RID: 30435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E3")]
		[Address(RVA = "0x1FB932C", Offset = "0x1FB932C", VA = "0x7BBC7B932C")]
		private void ShowBagVfx()
		{
		}

		// Token: 0x060076E4 RID: 30436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076E4")]
		[Address(RVA = "0x1FB969C", Offset = "0x1FB969C", VA = "0x7BBC7B969C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1141B08", Offset = "0x1141B08")]
		private IEnumerator BagVFXCoroutine()
		{
			return null;
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076E5")]
		[Address(RVA = "0x1FB9628", Offset = "0x1FB9628", VA = "0x7BBC7B9628")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1141B6C", Offset = "0x1141B6C")]
		private IEnumerator TokenVFXCoroutine()
		{
			return null;
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E6")]
		[Address(RVA = "0x1FB7C6C", Offset = "0x1FB7C6C", VA = "0x7BBC7B7C6C")]
		private void BeginPlayDrawAnim()
		{
		}

		// Token: 0x060076E7 RID: 30439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E7")]
		[Address(RVA = "0x1FB9888", Offset = "0x1FB9888", VA = "0x7BBC7B9888")]
		private void PlayNormalAnim()
		{
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E8")]
		[Address(RVA = "0x1FB9A28", Offset = "0x1FB9A28", VA = "0x7BBC7B9A28")]
		private void EndPlayDropBoxDrawAnim()
		{
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E9")]
		[Address(RVA = "0x1FB9768", Offset = "0x1FB9768", VA = "0x7BBC7B9768")]
		private void PlayLegendThemeAnim()
		{
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EA")]
		[Address(RVA = "0x1FB9A78", Offset = "0x1FB9A78", VA = "0x7BBC7B9A78")]
		private void EndPlayLegendThemeAnim()
		{
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EB")]
		[Address(RVA = "0x1FB8A70", Offset = "0x1FB8A70", VA = "0x7BBC7B8A70")]
		private void OnEndPlayDrawAnim()
		{
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EC")]
		[Address(RVA = "0x1FB4728", Offset = "0x1FB4728", VA = "0x7BBC7B4728")]
		private void InitExtraRewardItems()
		{
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076ED")]
		[Address(RVA = "0x1FB4E94", Offset = "0x1FB4E94", VA = "0x7BBC7B4E94")]
		private void OnExchangeAnimInterfaceMaskClick()
		{
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EE")]
		[Address(RVA = "0x1FB80CC", Offset = "0x1FB80CC", VA = "0x7BBC7B80CC")]
		public void RefreshExtraRewardList(uint chestID)
		{
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EF")]
		[Address(RVA = "0x1FB9B58", Offset = "0x1FB9B58", VA = "0x7BBC7B9B58")]
		private void OnShowExchangeAnim(object[] data)
		{
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F0")]
		[Address(RVA = "0x1FB45D8", Offset = "0x1FB45D8", VA = "0x7BBC7B45D8")]
		private void InitTransList()
		{
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x00020E80 File Offset: 0x0001F080
		[Token(Token = "0x60076F1")]
		[Address(RVA = "0x1FBA0A8", Offset = "0x1FBA0A8", VA = "0x7BBC7BA0A8", Slot = "29")]
		public new uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F2")]
		[Address(RVA = "0x1FBA0EC", Offset = "0x1FBA0EC", VA = "0x7BBC7BA0EC", Slot = "46")]
		public override void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F3")]
		[Address(RVA = "0x1FBA274", Offset = "0x1FBA274", VA = "0x7BBC7BA274")]
		public void ClearCache()
		{
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076F4")]
		[Address(RVA = "0x1FBA37C", Offset = "0x1FBA37C", VA = "0x7BBC7BA37C", Slot = "50")]
		public override string GetTutorialWndTitleKey()
		{
			return null;
		}

		// Token: 0x060076F5 RID: 30453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F5")]
		[Address(RVA = "0x1FB834C", Offset = "0x1FB834C", VA = "0x7BBC7B834C")]
		private void RefreshNewTip()
		{
		}

		// Token: 0x060076F6 RID: 30454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F6")]
		[Address(RVA = "0x1FBA3C4", Offset = "0x1FBA3C4", VA = "0x7BBC7BA3C4")]
		public UIGachalegendaryNewContentController()
		{
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F7")]
		[Address(RVA = "0x1FBA4D4", Offset = "0x1FBA4D4", VA = "0x7BBC7BA4D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1141BD0", Offset = "0x1141BD0")]
		private void <ShowBubble>b__35_0()
		{
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F8")]
		[Address(RVA = "0x1FBA530", Offset = "0x1FBA530", VA = "0x7BBC7BA530")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1141BE0", Offset = "0x1141BE0")]
		private void <ShowExchangeResultWnd>b__62_1()
		{
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F9")]
		[Address(RVA = "0x1FBA68C", Offset = "0x1FBA68C", VA = "0x7BBC7BA68C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1141BF0", Offset = "0x1141BF0")]
		private void <BagVFXCoroutine>b__68_0()
		{
		}

		// Token: 0x04008D60 RID: 36192
		[Token(Token = "0x4008D60")]
		private const string DEFAULTBAGICONNAME = "FF_UI_Lottery_Bag_Normal";

		// Token: 0x04008D61 RID: 36193
		[Token(Token = "0x4008D61")]
		private const string BUBBLEGUIDEKEY = "BubbleGuideKey";

		// Token: 0x04008D62 RID: 36194
		[Token(Token = "0x4008D62")]
		private const uint m_GrowUpTime = 1U;

		// Token: 0x04008D63 RID: 36195
		[Token(Token = "0x4008D63")]
		[FieldOffset(Offset = "0x78")]
		private uint m_CurrentTokenNum;

		// Token: 0x04008D64 RID: 36196
		[Token(Token = "0x4008D64")]
		[FieldOffset(Offset = "0x7C")]
		private uint m_CurrentExchangingTokenNum;

		// Token: 0x04008D65 RID: 36197
		[Token(Token = "0x4008D65")]
		[FieldOffset(Offset = "0x80")]
		private uint m_CurrentExchangingGachaID;

		// Token: 0x04008D66 RID: 36198
		[Token(Token = "0x4008D66")]
		[FieldOffset(Offset = "0x84")]
		private uint m_DelayCallID;

		// Token: 0x04008D67 RID: 36199
		[Token(Token = "0x4008D67")]
		[FieldOffset(Offset = "0x88")]
		private bool m_IsPlayingAnimation;

		// Token: 0x04008D68 RID: 36200
		[Token(Token = "0x4008D68")]
		[FieldOffset(Offset = "0x89")]
		private bool m_IsShowGachaAnim;

		// Token: 0x04008D69 RID: 36201
		[Token(Token = "0x4008D69")]
		[FieldOffset(Offset = "0x8A")]
		private bool m_IsInPreview;

		// Token: 0x04008D6A RID: 36202
		[Token(Token = "0x4008D6A")]
		[FieldOffset(Offset = "0x8B")]
		private bool m_IsLegendClothGacha;

		// Token: 0x04008D6B RID: 36203
		[Token(Token = "0x4008D6B")]
		[FieldOffset(Offset = "0x90")]
		private UIGachalegendaryNewContentView m_View;

		// Token: 0x04008D6C RID: 36204
		[Token(Token = "0x4008D6C")]
		[FieldOffset(Offset = "0x98")]
		private UIModelGacha m_ModelGacha;

		// Token: 0x04008D6D RID: 36205
		[Token(Token = "0x4008D6D")]
		[FieldOffset(Offset = "0xA0")]
		private CSSharedItemDataManager.StoreQuality m_CurrentDropQuality;

		// Token: 0x04008D6E RID: 36206
		[Token(Token = "0x4008D6E")]
		[FieldOffset(Offset = "0xA8")]
		private GachaLengendaryInfoData m_GachaInfoData;

		// Token: 0x04008D6F RID: 36207
		[Token(Token = "0x4008D6F")]
		[FieldOffset(Offset = "0xB0")]
		private UILegendDrawAnimPopWindowController m_AnimPopWnd;

		// Token: 0x04008D70 RID: 36208
		[Token(Token = "0x4008D70")]
		[FieldOffset(Offset = "0xB8")]
		private GachaDesc m_GachaDesc;

		// Token: 0x04008D71 RID: 36209
		[Token(Token = "0x4008D71")]
		[FieldOffset(Offset = "0xC0")]
		private List<Transform> m_ExtraItemTransList;

		// Token: 0x04008D72 RID: 36210
		[Token(Token = "0x4008D72")]
		[FieldOffset(Offset = "0xC8")]
		private List<UIToggleButton> m_ToggleList;

		// Token: 0x04008D73 RID: 36211
		[Token(Token = "0x4008D73")]
		[FieldOffset(Offset = "0xD0")]
		private List<UIGachaLengendaryExtraListItemController> m_ExtraRewardList;

		// Token: 0x04008D74 RID: 36212
		[Token(Token = "0x4008D74")]
		[FieldOffset(Offset = "0xD8")]
		private GameObject m_LegendThemAnimObj;

		// Token: 0x04008D75 RID: 36213
		[Token(Token = "0x4008D75")]
		[FieldOffset(Offset = "0xE0")]
		private GameObject m_LegendThemExchangeAnimObj;

		// Token: 0x04008D76 RID: 36214
		[Token(Token = "0x4008D76")]
		[FieldOffset(Offset = "0xE8")]
		private List<uint> m_NewTempBagList;

		// Token: 0x04008D77 RID: 36215
		[Token(Token = "0x4008D77")]
		[FieldOffset(Offset = "0xF0")]
		private Coroutine m_ProgressCoroutine;

		// Token: 0x04008D78 RID: 36216
		[Token(Token = "0x4008D78")]
		[FieldOffset(Offset = "0xF8")]
		private List<ExchangedAward> Extra_rewards;

		// Token: 0x020017F0 RID: 6128
		[Token(Token = "0x20017F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F31DC", Offset = "0x10F31DC")]
		private sealed class <PlayProgressAnim>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060076FA RID: 30458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076FA")]
			[Address(RVA = "0x1FB60B0", Offset = "0x1FB60B0", VA = "0x7BBC7B60B0")]
			[DebuggerHidden]
			public <PlayProgressAnim>d__42(int <>1__state)
			{
			}

			// Token: 0x060076FB RID: 30459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076FB")]
			[Address(RVA = "0x1FBB264", Offset = "0x1FBB264", VA = "0x7BBC7BB264", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060076FC RID: 30460 RVA: 0x00020E98 File Offset: 0x0001F098
			[Token(Token = "0x60076FC")]
			[Address(RVA = "0x1FBB268", Offset = "0x1FBB268", VA = "0x7BBC7BB268", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000957 RID: 2391
			// (get) Token: 0x060076FD RID: 30461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000957")]
			private object Current
			{
				[Token(Token = "0x60076FD")]
				[Address(RVA = "0x1FBB49C", Offset = "0x1FBB49C", VA = "0x7BBC7BB49C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060076FE RID: 30462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076FE")]
			[Address(RVA = "0x1FBB4A4", Offset = "0x1FBB4A4", VA = "0x7BBC7BB4A4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000958 RID: 2392
			// (get) Token: 0x060076FF RID: 30463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000958")]
			private object Current
			{
				[Token(Token = "0x60076FF")]
				[Address(RVA = "0x1FBB50C", Offset = "0x1FBB50C", VA = "0x7BBC7BB50C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008D79 RID: 36217
			[Token(Token = "0x4008D79")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008D7A RID: 36218
			[Token(Token = "0x4008D7A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008D7B RID: 36219
			[Token(Token = "0x4008D7B")]
			[FieldOffset(Offset = "0x20")]
			public UIGachalegendaryNewContentController <>4__this;

			// Token: 0x04008D7C RID: 36220
			[Token(Token = "0x4008D7C")]
			[FieldOffset(Offset = "0x28")]
			public int startPoint;

			// Token: 0x04008D7D RID: 36221
			[Token(Token = "0x4008D7D")]
			[FieldOffset(Offset = "0x2C")]
			public int endPoint;

			// Token: 0x04008D7E RID: 36222
			[Token(Token = "0x4008D7E")]
			[FieldOffset(Offset = "0x30")]
			private float <start_value>5__2;

			// Token: 0x04008D7F RID: 36223
			[Token(Token = "0x4008D7F")]
			[FieldOffset(Offset = "0x34")]
			private float <perTimeChange>5__3;

			// Token: 0x04008D80 RID: 36224
			[Token(Token = "0x4008D80")]
			[FieldOffset(Offset = "0x38")]
			private float <cur_time>5__4;
		}

		// Token: 0x020017F1 RID: 6129
		[Token(Token = "0x20017F1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F31EC", Offset = "0x10F31EC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007701 RID: 30465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007701")]
			[Address(RVA = "0x1FBA74C", Offset = "0x1FBA74C", VA = "0x7BBC7BA74C")]
			public <>c()
			{
			}

			// Token: 0x06007702 RID: 30466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007702")]
			[Address(RVA = "0x1FBA754", Offset = "0x1FBA754", VA = "0x7BBC7BA754")]
			internal CommonRewardItemInfo <ShowDrawResult>b__61_0(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x06007703 RID: 30467 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007703")]
			[Address(RVA = "0x1FBA760", Offset = "0x1FBA760", VA = "0x7BBC7BA760")]
			internal CommonRewardItemInfo <ShowExchangeResultWnd>b__62_0(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x04008D81 RID: 36225
			[Token(Token = "0x4008D81")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIGachalegendaryNewContentController.<>c <>9;

			// Token: 0x04008D82 RID: 36226
			[Token(Token = "0x4008D82")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__61_0;

			// Token: 0x04008D83 RID: 36227
			[Token(Token = "0x4008D83")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__62_0;
		}

		// Token: 0x020017F2 RID: 6130
		[Token(Token = "0x20017F2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F31FC", Offset = "0x10F31FC")]
		private sealed class <BagVFXCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007704 RID: 30468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007704")]
			[Address(RVA = "0x1FB9710", Offset = "0x1FB9710", VA = "0x7BBC7B9710")]
			[DebuggerHidden]
			public <BagVFXCoroutine>d__68(int <>1__state)
			{
			}

			// Token: 0x06007705 RID: 30469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007705")]
			[Address(RVA = "0x1FBA76C", Offset = "0x1FBA76C", VA = "0x7BBC7BA76C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007706 RID: 30470 RVA: 0x00020EB0 File Offset: 0x0001F0B0
			[Token(Token = "0x6007706")]
			[Address(RVA = "0x1FBA770", Offset = "0x1FBA770", VA = "0x7BBC7BA770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000959 RID: 2393
			// (get) Token: 0x06007707 RID: 30471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000959")]
			private object Current
			{
				[Token(Token = "0x6007707")]
				[Address(RVA = "0x1FBB1EC", Offset = "0x1FBB1EC", VA = "0x7BBC7BB1EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007708 RID: 30472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007708")]
			[Address(RVA = "0x1FBB1F4", Offset = "0x1FBB1F4", VA = "0x7BBC7BB1F4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700095A RID: 2394
			// (get) Token: 0x06007709 RID: 30473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700095A")]
			private object Current
			{
				[Token(Token = "0x6007709")]
				[Address(RVA = "0x1FBB25C", Offset = "0x1FBB25C", VA = "0x7BBC7BB25C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008D84 RID: 36228
			[Token(Token = "0x4008D84")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008D85 RID: 36229
			[Token(Token = "0x4008D85")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008D86 RID: 36230
			[Token(Token = "0x4008D86")]
			[FieldOffset(Offset = "0x20")]
			public UIGachalegendaryNewContentController <>4__this;

			// Token: 0x04008D87 RID: 36231
			[Token(Token = "0x4008D87")]
			[FieldOffset(Offset = "0x28")]
			private float <mF1>5__2;

			// Token: 0x04008D88 RID: 36232
			[Token(Token = "0x4008D88")]
			[FieldOffset(Offset = "0x2C")]
			private float <mF2>5__3;

			// Token: 0x04008D89 RID: 36233
			[Token(Token = "0x4008D89")]
			[FieldOffset(Offset = "0x30")]
			private float <timeCounter>5__4;

			// Token: 0x04008D8A RID: 36234
			[Token(Token = "0x4008D8A")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 <startPos>5__5;

			// Token: 0x04008D8B RID: 36235
			[Token(Token = "0x4008D8B")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 <endPos>5__6;
		}

		// Token: 0x020017F3 RID: 6131
		[Token(Token = "0x20017F3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F320C", Offset = "0x10F320C")]
		private sealed class <TokenVFXCoroutine>d__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600770A RID: 30474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600770A")]
			[Address(RVA = "0x1FB973C", Offset = "0x1FB973C", VA = "0x7BBC7B973C")]
			[DebuggerHidden]
			public <TokenVFXCoroutine>d__69(int <>1__state)
			{
			}

			// Token: 0x0600770B RID: 30475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600770B")]
			[Address(RVA = "0x1FBB514", Offset = "0x1FBB514", VA = "0x7BBC7BB514", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600770C RID: 30476 RVA: 0x00020EC8 File Offset: 0x0001F0C8
			[Token(Token = "0x600770C")]
			[Address(RVA = "0x1FBB518", Offset = "0x1FBB518", VA = "0x7BBC7BB518", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700095B RID: 2395
			// (get) Token: 0x0600770D RID: 30477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700095B")]
			private object Current
			{
				[Token(Token = "0x600770D")]
				[Address(RVA = "0x1FBB9D8", Offset = "0x1FBB9D8", VA = "0x7BBC7BB9D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600770E RID: 30478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600770E")]
			[Address(RVA = "0x1FBB9E0", Offset = "0x1FBB9E0", VA = "0x7BBC7BB9E0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700095C RID: 2396
			// (get) Token: 0x0600770F RID: 30479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700095C")]
			private object Current
			{
				[Token(Token = "0x600770F")]
				[Address(RVA = "0x1FBBA48", Offset = "0x1FBBA48", VA = "0x7BBC7BBA48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008D8C RID: 36236
			[Token(Token = "0x4008D8C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008D8D RID: 36237
			[Token(Token = "0x4008D8D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008D8E RID: 36238
			[Token(Token = "0x4008D8E")]
			[FieldOffset(Offset = "0x20")]
			public UIGachalegendaryNewContentController <>4__this;

			// Token: 0x04008D8F RID: 36239
			[Token(Token = "0x4008D8F")]
			[FieldOffset(Offset = "0x28")]
			private float <mF1>5__2;

			// Token: 0x04008D90 RID: 36240
			[Token(Token = "0x4008D90")]
			[FieldOffset(Offset = "0x2C")]
			private float <mF2>5__3;

			// Token: 0x04008D91 RID: 36241
			[Token(Token = "0x4008D91")]
			[FieldOffset(Offset = "0x30")]
			private float <timeCounter>5__4;

			// Token: 0x04008D92 RID: 36242
			[Token(Token = "0x4008D92")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 <startPos>5__5;

			// Token: 0x04008D93 RID: 36243
			[Token(Token = "0x4008D93")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 <endPos>5__6;
		}
	}
}
