using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017E2 RID: 6114
	[Token(Token = "0x20017E2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2F64", Offset = "0x10F2F64")]
	public class UIGachaController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x06007606 RID: 30214 RVA: 0x00020BE0 File Offset: 0x0001EDE0
		[Token(Token = "0x6007606")]
		[Address(RVA = "0x2156A20", Offset = "0x2156A20", VA = "0x7BBC956A20")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		[Token(Token = "0x6007607")]
		[Address(RVA = "0x2156A70", Offset = "0x2156A70", VA = "0x7BBC956A70", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06007608 RID: 30216 RVA: 0x00020C10 File Offset: 0x0001EE10
		[Token(Token = "0x6007608")]
		[Address(RVA = "0x2156A78", Offset = "0x2156A78", VA = "0x7BBC956A78", Slot = "32")]
		protected override bool NeedWaitDataReady()
		{
			return default(bool);
		}

		// Token: 0x06007609 RID: 30217 RVA: 0x00020C28 File Offset: 0x0001EE28
		[Token(Token = "0x6007609")]
		[Address(RVA = "0x2156A80", Offset = "0x2156A80", VA = "0x7BBC956A80", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600760A RID: 30218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600760A")]
		[Address(RVA = "0x2156B24", Offset = "0x2156B24", VA = "0x7BBC956B24", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x0600760B RID: 30219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600760B")]
		[Address(RVA = "0x2156D9C", Offset = "0x2156D9C", VA = "0x7BBC956D9C", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x0600760C RID: 30220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600760C")]
		[Address(RVA = "0x21578C8", Offset = "0x21578C8", VA = "0x7BBC9578C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600760D RID: 30221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600760D")]
		[Address(RVA = "0x2158CE0", Offset = "0x2158CE0", VA = "0x7BBC958CE0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600760E RID: 30222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600760E")]
		[Address(RVA = "0x2158D1C", Offset = "0x2158D1C", VA = "0x7BBC958D1C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600760F")]
		[Address(RVA = "0x21595A4", Offset = "0x21595A4", VA = "0x7BBC9595A4", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007610")]
		[Address(RVA = "0x215ADD0", Offset = "0x215ADD0", VA = "0x7BBC95ADD0")]
		private void OnRuleClicked(params object[] param)
		{
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007611")]
		[Address(RVA = "0x215AFD8", Offset = "0x215AFD8", VA = "0x7BBC95AFD8")]
		private void OnExchangeActivityBtnClick(params object[] param)
		{
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007612")]
		[Address(RVA = "0x21572E8", Offset = "0x21572E8", VA = "0x7BBC9572E8")]
		private void SelectChooseTab()
		{
		}

		// Token: 0x06007613 RID: 30227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007613")]
		[Address(RVA = "0x215B0B0", Offset = "0x215B0B0", VA = "0x7BBC95B0B0")]
		private void OnAnimPlayBtnClick(params object[] param)
		{
		}

		// Token: 0x06007614 RID: 30228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007614")]
		[Address(RVA = "0x215B164", Offset = "0x215B164", VA = "0x7BBC95B164")]
		private void OnCDNChangeBtnClick(params object[] param)
		{
		}

		// Token: 0x06007615 RID: 30229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007615")]
		[Address(RVA = "0x215BBC4", Offset = "0x215BBC4", VA = "0x7BBC95BBC4")]
		private void OnChangeLegendaryAvatar(params object[] param)
		{
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007616")]
		[Address(RVA = "0x215BC68", Offset = "0x215BC68", VA = "0x7BBC95BC68")]
		private void OnPropsClick(params object[] param)
		{
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007617")]
		[Address(RVA = "0x215C334", Offset = "0x215C334", VA = "0x7BBC95C334")]
		private void OnPropsClose()
		{
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007618")]
		[Address(RVA = "0x215C378", Offset = "0x215C378", VA = "0x7BBC95C378")]
		private void OnInterfaceMackClick()
		{
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007619")]
		[Address(RVA = "0x215C41C", Offset = "0x215C41C", VA = "0x7BBC95C41C")]
		private void OnInterfaceContentMaskClick()
		{
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x00020C40 File Offset: 0x0001EE40
		[Token(Token = "0x600761A")]
		[Address(RVA = "0x2157290", Offset = "0x2157290", VA = "0x7BBC957290")]
		private int GetDefTabIdx()
		{
			return 0;
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x00020C58 File Offset: 0x0001EE58
		[Token(Token = "0x600761B")]
		[Address(RVA = "0x2157278", Offset = "0x2157278", VA = "0x7BBC957278")]
		private int ChestID2TabIdx(int chestID)
		{
			return 0;
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x00020C70 File Offset: 0x0001EE70
		[Token(Token = "0x600761C")]
		[Address(RVA = "0x215AD8C", Offset = "0x215AD8C", VA = "0x7BBC95AD8C")]
		private uint TabIdx2ChestID(int tabIdx)
		{
			return 0U;
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600761D")]
		[Address(RVA = "0x215A2B8", Offset = "0x215A2B8", VA = "0x7BBC95A2B8")]
		private void OnGachaTabClick(params object[] param)
		{
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600761E")]
		[Address(RVA = "0x215C5E8", Offset = "0x215C5E8", VA = "0x7BBC95C5E8")]
		private void RefreshTabBtnState(int selectedTabIdx)
		{
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600761F")]
		[Address(RVA = "0x2157594", Offset = "0x2157594", VA = "0x7BBC957594")]
		private void RefreshGachaScene()
		{
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x00020C88 File Offset: 0x0001EE88
		[Token(Token = "0x6007620")]
		[Address(RVA = "0x215B344", Offset = "0x215B344", VA = "0x7BBC95B344")]
		private bool CheckNeedPlayAnimByDate()
		{
			return default(bool);
		}

		// Token: 0x06007621 RID: 30241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007621")]
		[Address(RVA = "0x215D05C", Offset = "0x215D05C", VA = "0x7BBC95D05C")]
		private void RefreshUIScene()
		{
		}

		// Token: 0x06007622 RID: 30242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007622")]
		[Address(RVA = "0x2159DA4", Offset = "0x2159DA4", VA = "0x7BBC959DA4")]
		private void RefreshGachaTabsView(params object[] param)
		{
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007623")]
		[Address(RVA = "0x215D0C8", Offset = "0x215D0C8", VA = "0x7BBC95D0C8")]
		private void RefreshGachaBG()
		{
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007624")]
		[Address(RVA = "0x215D56C", Offset = "0x215D56C", VA = "0x7BBC95D56C")]
		private void RefreshAnimPlayBtnView()
		{
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007625")]
		[Address(RVA = "0x215D6BC", Offset = "0x215D6BC", VA = "0x7BBC95D6BC")]
		private void RefreshShowChangePlayBtnView()
		{
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007626")]
		[Address(RVA = "0x215A49C", Offset = "0x215A49C", VA = "0x7BBC95A49C")]
		private void RefreshPropsView()
		{
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007627")]
		[Address(RVA = "0x215D440", Offset = "0x215D440", VA = "0x7BBC95D440")]
		private void RefreshContentView()
		{
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007628")]
		[Address(RVA = "0x215D9E4", Offset = "0x215D9E4", VA = "0x7BBC95D9E4", Slot = "22")]
		public override void Hide()
		{
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007629")]
		[Address(RVA = "0x215DAAC", Offset = "0x215DAAC", VA = "0x7BBC95DAAC", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600762A")]
		[Address(RVA = "0x215DB74", Offset = "0x215DB74", VA = "0x7BBC95DB74")]
		private void HideViewOnPlayAnimtion(params object[] param)
		{
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600762B")]
		[Address(RVA = "0x215DD34", Offset = "0x215DD34", VA = "0x7BBC95DD34")]
		private void ShowViewOnOverAnimtion(params object[] param)
		{
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762C")]
		[Address(RVA = "0x215C7D4", Offset = "0x215C7D4", VA = "0x7BBC95C7D4")]
		private UIGachaContentBase GetGachaContent(ELottery.Type type)
		{
			return null;
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600762D")]
		[Address(RVA = "0x2159BFC", Offset = "0x2159BFC", VA = "0x7BBC959BFC")]
		private void CheckGachaOpen()
		{
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600762E")]
		[Address(RVA = "0x2159F94", Offset = "0x2159F94", VA = "0x7BBC959F94")]
		private void CheckAwardIsExist()
		{
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600762F")]
		[Address(RVA = "0x215A0E0", Offset = "0x215A0E0", VA = "0x7BBC95A0E0")]
		private void InitGachaTab()
		{
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x00020CA0 File Offset: 0x0001EEA0
		[Token(Token = "0x6007630")]
		[Address(RVA = "0x215CC8C", Offset = "0x215CC8C", VA = "0x7BBC95CC8C")]
		private bool TryShowTutorialWnd([Optional] Action CloseCallBack)
		{
			return default(bool);
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007631")]
		[Address(RVA = "0x215DF38", Offset = "0x215DF38", VA = "0x7BBC95DF38")]
		private void OnWebViewClose()
		{
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007632")]
		[Address(RVA = "0x215DFE0", Offset = "0x215DFE0", VA = "0x7BBC95DFE0")]
		private void OnCloseRewardPanel(params object[] data)
		{
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007633")]
		[Address(RVA = "0x215E0B8", Offset = "0x215E0B8", VA = "0x7BBC95E0B8")]
		private void OnGachaAnimSkip(params object[] data)
		{
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007634")]
		[Address(RVA = "0x215DCA0", Offset = "0x215DCA0", VA = "0x7BBC95DCA0")]
		public void PlayShowAnim(bool isShow)
		{
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007635")]
		[Address(RVA = "0x2158780", Offset = "0x2158780", VA = "0x7BBC958780")]
		public void SetInterfaceMaskEnable(params object[] param)
		{
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007636")]
		[Address(RVA = "0x215E0E8", Offset = "0x215E0E8", VA = "0x7BBC95E0E8")]
		private void SetInterfaceMaskLabelEnable(bool v)
		{
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007637")]
		[Address(RVA = "0x2158C64", Offset = "0x2158C64", VA = "0x7BBC958C64")]
		public void SetContentMaskEnable(bool v)
		{
		}

		// Token: 0x06007638 RID: 30264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007638")]
		[Address(RVA = "0x215E148", Offset = "0x215E148", VA = "0x7BBC95E148")]
		public void SetContentMMaskLabelEnable(bool v)
		{
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x00020CB8 File Offset: 0x0001EEB8
		[Token(Token = "0x6007639")]
		[Address(RVA = "0x215E1A8", Offset = "0x215E1A8", VA = "0x7BBC95E1A8", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x0600763A RID: 30266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600763A")]
		[Address(RVA = "0x215E1B0", Offset = "0x215E1B0", VA = "0x7BBC95E1B0")]
		private void OnRewardPoolClose(params object[] data)
		{
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600763B")]
		[Address(RVA = "0x215E44C", Offset = "0x215E44C", VA = "0x7BBC95E44C")]
		private void ShowChangeSceneMask()
		{
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600763C")]
		[Address(RVA = "0x2156D04", Offset = "0x2156D04", VA = "0x7BBC956D04")]
		private void CloseRewardPool()
		{
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600763D")]
		[Address(RVA = "0x215E540", Offset = "0x215E540", VA = "0x7BBC95E540")]
		private void OnRewardPoolItemSelected(params object[] data)
		{
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600763E")]
		[Address(RVA = "0x215E62C", Offset = "0x215E62C", VA = "0x7BBC95E62C")]
		private void OnAnimOver(params object[] data)
		{
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600763F")]
		[Address(RVA = "0x215E704", Offset = "0x215E704", VA = "0x7BBC95E704")]
		private void OnAvatarClear(params object[] data)
		{
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007640")]
		[Address(RVA = "0x215E734", Offset = "0x215E734", VA = "0x7BBC95E734")]
		private void OnWeaponCgUIShow(params object[] data)
		{
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007641")]
		[Address(RVA = "0x215E7D4", Offset = "0x215E7D4", VA = "0x7BBC95E7D4")]
		private void OnWeaponCgUIHide(params object[] data)
		{
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007642")]
		[Address(RVA = "0x215E808", Offset = "0x215E808", VA = "0x7BBC95E808")]
		private void OnRewardPoolOpen(params object[] data)
		{
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007643")]
		[Address(RVA = "0x215B710", Offset = "0x215B710", VA = "0x7BBC95B710")]
		private void CheckForPlayGachaAnimation()
		{
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007644")]
		[Address(RVA = "0x215ED54", Offset = "0x215ED54", VA = "0x7BBC95ED54")]
		private void ProcessAnimEvt(object[] data)
		{
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007645")]
		[Address(RVA = "0x215EE20", Offset = "0x215EE20", VA = "0x7BBC95EE20")]
		private void OnFullScreenPreviewClose(params object[] data)
		{
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007646")]
		[Address(RVA = "0x215F0D4", Offset = "0x215F0D4", VA = "0x7BBC95F0D4")]
		private void OnFullScreenPreviewOpen(params object[] data)
		{
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007647")]
		[Address(RVA = "0x215F10C", Offset = "0x215F10C", VA = "0x7BBC95F10C")]
		public UIGachaController()
		{
		}

		// Token: 0x04008D1D RID: 36125
		[Token(Token = "0x4008D1D")]
		public const string SHOW_ANIM_KEY = "ShowAnim_Gacha_";

		// Token: 0x04008D1E RID: 36126
		[Token(Token = "0x4008D1E")]
		public const int MAXTABNUMINGRID = 6;

		// Token: 0x04008D1F RID: 36127
		[Token(Token = "0x4008D1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UIGachaView m_View;

		// Token: 0x04008D20 RID: 36128
		[Token(Token = "0x4008D20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UIModelGacha m_ModelGacha;

		// Token: 0x04008D21 RID: 36129
		[Token(Token = "0x4008D21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int m_SelectedTabIdx;

		// Token: 0x04008D22 RID: 36130
		[Token(Token = "0x4008D22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int m_LastSelectedTabIdx;

		// Token: 0x04008D23 RID: 36131
		[Token(Token = "0x4008D23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<UIGachaTabItemController> m_TabCtrlList;

		// Token: 0x04008D24 RID: 36132
		[Token(Token = "0x4008D24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Dictionary<int, bool> m_FirstEnterFlagList;

		// Token: 0x04008D25 RID: 36133
		[Token(Token = "0x4008D25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AdType m_CurGachaBGType;

		// Token: 0x04008D26 RID: 36134
		[Token(Token = "0x4008D26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private UIGachaNormalContent m_NormalContentCtrl;

		// Token: 0x04008D27 RID: 36135
		[Token(Token = "0x4008D27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private UIGachaTurntableContent m_TurntabelContentCtrl;

		// Token: 0x04008D28 RID: 36136
		[Token(Token = "0x4008D28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private UIGachaLimitContent m_LimitContentCtrl;

		// Token: 0x04008D29 RID: 36137
		[Token(Token = "0x4008D29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private UIGachaTokenContent m_TokenContentCtrl;

		// Token: 0x04008D2A RID: 36138
		[Token(Token = "0x4008D2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private UIGachaEnergyContent m_EnergyContentCtrl;

		// Token: 0x04008D2B RID: 36139
		[Token(Token = "0x4008D2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private UIGachalegendaryNewContentController m_legendaryContentCtrl;

		// Token: 0x04008D2C RID: 36140
		[Token(Token = "0x4008D2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private UIGachaContentBase m_CurContent;

		// Token: 0x04008D2D RID: 36141
		[Token(Token = "0x4008D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private uint m_RewardPoolJumpItmID;

		// Token: 0x04008D2E RID: 36142
		[Token(Token = "0x4008D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private uint m_RewardPoolSelectedItmID;

		// Token: 0x04008D2F RID: 36143
		[Token(Token = "0x4008D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private UIGachaPreviewController m_RewardPoolCtrl;

		// Token: 0x04008D30 RID: 36144
		[Token(Token = "0x4008D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private UIGachaPreviewManager m_GachaPreviewManager;

		// Token: 0x04008D31 RID: 36145
		[Token(Token = "0x4008D31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool m_EnterNotifyState;

		// Token: 0x04008D32 RID: 36146
		[Token(Token = "0x4008D32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		private bool m_HasShowFullScreenPreview;

		// Token: 0x04008D33 RID: 36147
		[Token(Token = "0x4008D33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private List<UIGachaCouponTipsController> m_CouponItemList;

		// Token: 0x04008D34 RID: 36148
		[Token(Token = "0x4008D34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private int m_CurrentOwnedCouponTypeCnt;
	}
}
