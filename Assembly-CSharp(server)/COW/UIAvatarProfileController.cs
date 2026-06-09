using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016BB RID: 5819
	[Token(Token = "0x20016BB")]
	public class UIAvatarProfileController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06006A4E RID: 27214 RVA: 0x0001E2A0 File Offset: 0x0001C4A0
		[Token(Token = "0x6006A4E")]
		[Address(RVA = "0x207AE14", Offset = "0x207AE14", VA = "0x7BBC87AE14")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
		[Token(Token = "0x6006A4F")]
		[Address(RVA = "0x207AE64", Offset = "0x207AE64", VA = "0x7BBC87AE64", Slot = "29")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
		[Token(Token = "0x6006A50")]
		[Address(RVA = "0x207AEC8", Offset = "0x207AEC8", VA = "0x7BBC87AEC8")]
		private bool CheckSuitIsABReady(uint suitid)
		{
			return default(bool);
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A51")]
		[Address(RVA = "0x207AFC4", Offset = "0x207AFC4", VA = "0x7BBC87AFC4")]
		private void StartSuitPreview(uint avatarId, uint[] clothsIds)
		{
		}

		// Token: 0x06006A52 RID: 27218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A52")]
		[Address(RVA = "0x207B1F4", Offset = "0x207B1F4", VA = "0x7BBC87B1F4", Slot = "28")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A53")]
		[Address(RVA = "0x207BAB4", Offset = "0x207BAB4", VA = "0x7BBC87BAB4")]
		private void RefreshDefaultAvatarNode(bool flag = true)
		{
		}

		// Token: 0x06006A54 RID: 27220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A54")]
		[Address(RVA = "0x207C868", Offset = "0x207C868", VA = "0x7BBC87C868")]
		private void RefreshCommonAvatarNode(bool flag = true)
		{
		}

		// Token: 0x06006A55 RID: 27221 RVA: 0x0001E2E8 File Offset: 0x0001C4E8
		[Token(Token = "0x6006A55")]
		[Address(RVA = "0x207E234", Offset = "0x207E234", VA = "0x7BBC87E234")]
		private bool CheckHasTips(AvatarProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06006A56 RID: 27222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A56")]
		[Address(RVA = "0x207E2B4", Offset = "0x207E2B4", VA = "0x7BBC87E2B4")]
		public void SetCurrentAwakenSelect(uint avatarID, bool flag = true)
		{
		}

		// Token: 0x06006A57 RID: 27223 RVA: 0x0001E300 File Offset: 0x0001C500
		[Token(Token = "0x6006A57")]
		[Address(RVA = "0x207E5F0", Offset = "0x207E5F0", VA = "0x7BBC87E5F0")]
		private bool CheckHasAwakenTips(AvatarProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06006A58 RID: 27224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A58")]
		[Address(RVA = "0x207B75C", Offset = "0x207B75C", VA = "0x7BBC87B75C")]
		private void RefreshAwakenEntranceBtn()
		{
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A59")]
		[Address(RVA = "0x207E6E8", Offset = "0x207E6E8", VA = "0x7BBC87E6E8")]
		private void RefreshAwakenAvatarNode(bool flag = true, bool refresh = true)
		{
		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x0001E318 File Offset: 0x0001C518
		[Token(Token = "0x6006A5A")]
		[Address(RVA = "0x207E048", Offset = "0x207E048", VA = "0x7BBC87E048")]
		private uint GetAvatarDebrisLockCout(uint avatarid, uint level)
		{
			return 0U;
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5B")]
		[Address(RVA = "0x20807E0", Offset = "0x20807E0", VA = "0x7BBC8807E0")]
		private void StoryClick()
		{
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5C")]
		[Address(RVA = "0x2080948", Offset = "0x2080948", VA = "0x7BBC880948")]
		private void RefreshOnlyAvatar(uint avarid)
		{
		}

		// Token: 0x06006A5D RID: 27229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5D")]
		[Address(RVA = "0x2080D54", Offset = "0x2080D54", VA = "0x7BBC880D54")]
		private void OnDefaultStoryBtnClick()
		{
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5E")]
		[Address(RVA = "0x2080D58", Offset = "0x2080D58", VA = "0x7BBC880D58")]
		private void OnCommonStoryBtnClick()
		{
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5F")]
		[Address(RVA = "0x2080D5C", Offset = "0x2080D5C", VA = "0x7BBC880D5C")]
		private void OnAwakenStoryBtnClick()
		{
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A60")]
		[Address(RVA = "0x2080D60", Offset = "0x2080D60", VA = "0x7BBC880D60")]
		private void OnDefaultVoicePlayBtnClick()
		{
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A61")]
		[Address(RVA = "0x2080D64", Offset = "0x2080D64", VA = "0x7BBC880D64")]
		private void DefaultPlayRandomVoice()
		{
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A62")]
		[Address(RVA = "0x2080EE0", Offset = "0x2080EE0", VA = "0x7BBC880EE0")]
		private void StopDefaultVoicePlayingAnim()
		{
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A63")]
		[Address(RVA = "0x207C740", Offset = "0x207C740", VA = "0x7BBC87C740")]
		private void ShowDefaultVoicePlayingAnim(bool show)
		{
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A64")]
		[Address(RVA = "0x2080FB0", Offset = "0x2080FB0", VA = "0x7BBC880FB0")]
		private void OnCommonVoicePlayBtnClick()
		{
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A65")]
		[Address(RVA = "0x207DECC", Offset = "0x207DECC", VA = "0x7BBC87DECC")]
		private void CommonPlayRandomVoice()
		{
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A66")]
		[Address(RVA = "0x2080FB4", Offset = "0x2080FB4", VA = "0x7BBC880FB4")]
		private void StopCommonVoicePlayingAnim()
		{
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A67")]
		[Address(RVA = "0x207DDA4", Offset = "0x207DDA4", VA = "0x7BBC87DDA4")]
		private void ShowCommonVoicePlayingAnim(bool show)
		{
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A68")]
		[Address(RVA = "0x2081084", Offset = "0x2081084", VA = "0x7BBC881084")]
		private void OnAwakenVoicePlayBtnClick()
		{
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A69")]
		[Address(RVA = "0x2080664", Offset = "0x2080664", VA = "0x7BBC880664")]
		private void AwakenPlayRandomVoice()
		{
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A6A")]
		[Address(RVA = "0x2081088", Offset = "0x2081088", VA = "0x7BBC881088")]
		private void StopAwakenVoicePlayingAnim()
		{
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A6B")]
		[Address(RVA = "0x208053C", Offset = "0x208053C", VA = "0x7BBC88053C")]
		private void ShowAwakenVoicePlayingAnim(bool show)
		{
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A6C")]
		[Address(RVA = "0x2081158", Offset = "0x2081158", VA = "0x7BBC881158")]
		private void OnLevelUpClick()
		{
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A6D")]
		[Address(RVA = "0x2081580", Offset = "0x2081580", VA = "0x7BBC881580")]
		private void OnCommonSwitchBtnClick()
		{
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A6E")]
		[Address(RVA = "0x20817F8", Offset = "0x20817F8", VA = "0x7BBC8817F8")]
		private void OnAwakenSwitchBtnClick()
		{
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A6F")]
		[Address(RVA = "0x2081A70", Offset = "0x2081A70", VA = "0x7BBC881A70")]
		private void OnAwakenEntranceBtnClick()
		{
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A70")]
		[Address(RVA = "0x2081C48", Offset = "0x2081C48", VA = "0x7BBC881C48")]
		private void OnExchangeToAwakenAvatar()
		{
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A71")]
		[Address(RVA = "0x20820CC", Offset = "0x20820CC", VA = "0x7BBC8820CC")]
		private void OnExchangeToOriAvatar()
		{
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A72")]
		[Address(RVA = "0x2082534", Offset = "0x2082534", VA = "0x7BBC882534", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A73")]
		[Address(RVA = "0x2083AB8", Offset = "0x2083AB8", VA = "0x7BBC883AB8")]
		private void RefreshGuide(object[] data)
		{
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A74")]
		[Address(RVA = "0x2083ABC", Offset = "0x2083ABC", VA = "0x7BBC883ABC")]
		private void OnAwakenTipClick()
		{
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A75")]
		[Address(RVA = "0x2083D90", Offset = "0x2083D90", VA = "0x7BBC883D90")]
		private void OnCommonTipClick()
		{
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A76")]
		[Address(RVA = "0x2084064", Offset = "0x2084064", VA = "0x7BBC884064")]
		public void SetData(AvatarProfile profile, bool flag = true)
		{
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A77")]
		[Address(RVA = "0x2084170", Offset = "0x2084170", VA = "0x7BBC884170")]
		public void RefreshData(bool flag, bool refresh = true)
		{
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A78")]
		[Address(RVA = "0x2084268", Offset = "0x2084268", VA = "0x7BBC884268")]
		private void OnVoiceDownloadBtnClick()
		{
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A79")]
		[Address(RVA = "0x207B36C", Offset = "0x207B36C", VA = "0x7BBC87B36C")]
		private void RefreshVoiceBtnState()
		{
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x0001E330 File Offset: 0x0001C530
		[Token(Token = "0x6006A7A")]
		[Address(RVA = "0x20846C0", Offset = "0x20846C0", VA = "0x7BBC8846C0")]
		private bool CheckAvatarVoiceABIsReady(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A7B")]
		[Address(RVA = "0x2084954", Offset = "0x2084954", VA = "0x7BBC884954")]
		private void SetPveWeaponInfo(CSSharedAvatarData basicInfo)
		{
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A7C")]
		[Address(RVA = "0x2084B70", Offset = "0x2084B70", VA = "0x7BBC884B70", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006A7D RID: 27261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A7D")]
		[Address(RVA = "0x207C500", Offset = "0x207C500", VA = "0x7BBC87C500")]
		private void onSliderChange()
		{
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A7E")]
		[Address(RVA = "0x2084BBC", Offset = "0x2084BBC", VA = "0x7BBC884BBC")]
		private void onSliderThumbPress(GameObject go, bool state)
		{
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A7F")]
		[Address(RVA = "0x2084BC0", Offset = "0x2084BC0", VA = "0x7BBC884BC0")]
		private void OnTipBtnClick()
		{
		}

		// Token: 0x06006A80 RID: 27264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A80")]
		[Address(RVA = "0x2084C5C", Offset = "0x2084C5C", VA = "0x7BBC884C5C")]
		private void OnSkillLevelUpClick()
		{
		}

		// Token: 0x06006A81 RID: 27265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A81")]
		[Address(RVA = "0x2084C60", Offset = "0x2084C60", VA = "0x7BBC884C60")]
		private void OnAlignmentBtnClick()
		{
		}

		// Token: 0x06006A82 RID: 27266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A82")]
		[Address(RVA = "0x2084EA8", Offset = "0x2084EA8", VA = "0x7BBC884EA8")]
		private void OnAwakenSkillUpgradeClick()
		{
		}

		// Token: 0x06006A83 RID: 27267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A83")]
		[Address(RVA = "0x2084F80", Offset = "0x2084F80", VA = "0x7BBC884F80", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A84")]
		[Address(RVA = "0x20851F8", Offset = "0x20851F8", VA = "0x7BBC8851F8")]
		private void OnUpdateRedTips(params object[] param)
		{
		}

		// Token: 0x06006A85 RID: 27269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A85")]
		[Address(RVA = "0x2085300", Offset = "0x2085300", VA = "0x7BBC885300")]
		private void OnUpdateLevelMax(params object[] param)
		{
		}

		// Token: 0x06006A86 RID: 27270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A86")]
		[Address(RVA = "0x20855FC", Offset = "0x20855FC", VA = "0x7BBC8855FC")]
		private void OnUpdateAwakenData(params object[] param)
		{
		}

		// Token: 0x06006A87 RID: 27271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A87")]
		[Address(RVA = "0x2085478", Offset = "0x2085478", VA = "0x7BBC885478")]
		private void PlayAnimOneShotEvt(string voice_resourceid)
		{
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A88")]
		[Address(RVA = "0x2085738", Offset = "0x2085738", VA = "0x7BBC885738")]
		private void OnTouchLocalAvatar(params object[] param)
		{
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A89")]
		[Address(RVA = "0x2085880", Offset = "0x2085880", VA = "0x7BBC885880")]
		public void SetSlotCount()
		{
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A8A")]
		[Address(RVA = "0x2085A04", Offset = "0x2085A04", VA = "0x7BBC885A04")]
		public UIAvatarProfileController()
		{
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A8B")]
		[Address(RVA = "0x2085B10", Offset = "0x2085B10", VA = "0x7BBC885B10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140DE4", Offset = "0x1140DE4")]
		private void <OnUIInit>b__52_0(int length)
		{
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A8C")]
		[Address(RVA = "0x2085B5C", Offset = "0x2085B5C", VA = "0x7BBC885B5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140DF4", Offset = "0x1140DF4")]
		private void <OnUIInit>b__52_1(int length)
		{
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A8D")]
		[Address(RVA = "0x2085BA8", Offset = "0x2085BA8", VA = "0x7BBC885BA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140E04", Offset = "0x1140E04")]
		private void <OnUIInit>b__52_2(int length)
		{
		}

		// Token: 0x040086D4 RID: 34516
		[Token(Token = "0x40086D4")]
		[FieldOffset(Offset = "0x58")]
		private AvatarProfile m_Profile;

		// Token: 0x040086D5 RID: 34517
		[Token(Token = "0x40086D5")]
		[FieldOffset(Offset = "0x60")]
		private UIAvatarProfileView m_View;

		// Token: 0x040086D6 RID: 34518
		[Token(Token = "0x40086D6")]
		[FieldOffset(Offset = "0x68")]
		private Transform[] m_SlotList;

		// Token: 0x040086D7 RID: 34519
		[Token(Token = "0x40086D7")]
		[FieldOffset(Offset = "0x70")]
		private Transform[] m_SlotCommonList;

		// Token: 0x040086D8 RID: 34520
		[Token(Token = "0x40086D8")]
		[FieldOffset(Offset = "0x78")]
		private List<UIAvatarSkillSlotController> m_SlotCommonCtrlList;

		// Token: 0x040086D9 RID: 34521
		[Token(Token = "0x40086D9")]
		[FieldOffset(Offset = "0x80")]
		private Transform[] m_SlotAwakenList;

		// Token: 0x040086DA RID: 34522
		[Token(Token = "0x40086DA")]
		[FieldOffset(Offset = "0x88")]
		private List<UIAvatarSkillSlotController> m_SlotAwakenCtrlList;

		// Token: 0x040086DB RID: 34523
		[Token(Token = "0x40086DB")]
		[FieldOffset(Offset = "0x90")]
		private List<UIAvatarSkillSlotController> m_SlotCtrlList;

		// Token: 0x040086DC RID: 34524
		[Token(Token = "0x40086DC")]
		[FieldOffset(Offset = "0x98")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x040086DD RID: 34525
		[Token(Token = "0x40086DD")]
		[FieldOffset(Offset = "0xA0")]
		private UIAvatarSkillSlotController m_skillCtrl;

		// Token: 0x040086DE RID: 34526
		[Token(Token = "0x40086DE")]
		[FieldOffset(Offset = "0xA8")]
		private bool secondtime;

		// Token: 0x040086DF RID: 34527
		[Token(Token = "0x40086DF")]
		[FieldOffset(Offset = "0xAC")]
		private uint m_CurrentShowSuitID;

		// Token: 0x040086E0 RID: 34528
		[Token(Token = "0x40086E0")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_MaxLevel;

		// Token: 0x040086E1 RID: 34529
		[Token(Token = "0x40086E1")]
		[FieldOffset(Offset = "0xB8")]
		private AvatarSkillData m_SkillData;

		// Token: 0x040086E2 RID: 34530
		[Token(Token = "0x40086E2")]
		[FieldOffset(Offset = "0xC0")]
		private Color32 Blue;

		// Token: 0x040086E3 RID: 34531
		[Token(Token = "0x40086E3")]
		[FieldOffset(Offset = "0xC4")]
		private Color32 Yellow;

		// Token: 0x020016BC RID: 5820
		[Token(Token = "0x20016BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0AC4", Offset = "0x10F0AC4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006A8F RID: 27279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A8F")]
			[Address(RVA = "0x2085C58", Offset = "0x2085C58", VA = "0x7BBC885C58")]
			public <>c()
			{
			}

			// Token: 0x06006A90 RID: 27280 RVA: 0x0001E348 File Offset: 0x0001C548
			[Token(Token = "0x6006A90")]
			[Address(RVA = "0x2085C60", Offset = "0x2085C60", VA = "0x7BBC885C60")]
			internal bool <RefreshOnlyAvatar>b__30_0(AvatarSuit x)
			{
				return default(bool);
			}

			// Token: 0x06006A91 RID: 27281 RVA: 0x0001E360 File Offset: 0x0001C560
			[Token(Token = "0x6006A91")]
			[Address(RVA = "0x2085C8C", Offset = "0x2085C8C", VA = "0x7BBC885C8C")]
			internal ResourceID <OnVoiceDownloadBtnClick>b__58_0(AssistantAudioData audio)
			{
				return default(ResourceID);
			}

			// Token: 0x040086E4 RID: 34532
			[Token(Token = "0x40086E4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIAvatarProfileController.<>c <>9;

			// Token: 0x040086E5 RID: 34533
			[Token(Token = "0x40086E5")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<AvatarSuit> <>9__30_0;

			// Token: 0x040086E6 RID: 34534
			[Token(Token = "0x40086E6")]
			[FieldOffset(Offset = "0x10")]
			public static Func<AssistantAudioData, ResourceID> <>9__58_0;
		}
	}
}
