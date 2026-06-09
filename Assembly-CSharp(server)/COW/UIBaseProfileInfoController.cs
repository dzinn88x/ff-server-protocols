using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020016E7 RID: 5863
	[Token(Token = "0x20016E7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0FFC", Offset = "0x10F0FFC")]
	internal class UIBaseProfileInfoController : UIBaseController
	{
		// Token: 0x06006C60 RID: 27744 RVA: 0x0001EA20 File Offset: 0x0001CC20
		[Token(Token = "0x6006C60")]
		[Address(RVA = "0x14237C0", Offset = "0x14237C0", VA = "0x7BBBC237C0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006C61 RID: 27745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C61")]
		[Address(RVA = "0x1423810", Offset = "0x1423810", VA = "0x7BBBC23810", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C62")]
		[Address(RVA = "0x1424208", Offset = "0x1424208", VA = "0x7BBBC24208")]
		public void SetBoxColliderDisabled()
		{
		}

		// Token: 0x06006C63 RID: 27747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C63")]
		[Address(RVA = "0x14242AC", Offset = "0x14242AC", VA = "0x7BBBC242AC")]
		public void UpdateLevelRankUI(bool showLevel, bool showRank)
		{
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C64")]
		[Address(RVA = "0x1424364", Offset = "0x1424364", VA = "0x7BBBC24364")]
		public void SetCSUIdata(uint rank)
		{
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C65")]
		[Address(RVA = "0x14244FC", Offset = "0x14244FC", VA = "0x7BBBC244FC")]
		public void SetCSUIwithScore(uint rank, uint rankpoint)
		{
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C66")]
		[Address(RVA = "0x1424CA4", Offset = "0x1424CA4", VA = "0x7BBBC24CA4")]
		public void SetGender(ESocial.Gender gender)
		{
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C67")]
		[Address(RVA = "0x1424CAC", Offset = "0x1424CAC", VA = "0x7BBBC24CAC")]
		private void UpdateGender()
		{
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C68")]
		[Address(RVA = "0x1424E74", Offset = "0x1424E74", VA = "0x7BBBC24E74")]
		public void SetUIData(BaseProfileInfo data, uint showState = 0U)
		{
		}

		// Token: 0x06006C69 RID: 27753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C69")]
		[Address(RVA = "0x1425E34", Offset = "0x1425E34", VA = "0x7BBBC25E34")]
		public void UpdatePin(uint pinId)
		{
		}

		// Token: 0x06006C6A RID: 27754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6A")]
		[Address(RVA = "0x1426468", Offset = "0x1426468", VA = "0x7BBBC26468")]
		public void SetPinIconState(bool value, bool isBigIcon = false)
		{
		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6B")]
		[Address(RVA = "0x14264E8", Offset = "0x14264E8", VA = "0x7BBBC264E8")]
		private void OnBtnPinClick()
		{
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6C")]
		[Address(RVA = "0x1426000", Offset = "0x1426000", VA = "0x7BBBC26000")]
		public void UpdateBanner(uint bannerId)
		{
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6D")]
		[Address(RVA = "0x142660C", Offset = "0x142660C", VA = "0x7BBBC2660C")]
		public void UpdateBanner(BannerData bannerdata, bool isBrief = false)
		{
		}

		// Token: 0x06006C6E RID: 27758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6E")]
		[Address(RVA = "0x14267D8", Offset = "0x14267D8", VA = "0x7BBBC267D8")]
		public void UpdateHeadPic(HeadPicData data)
		{
		}

		// Token: 0x06006C6F RID: 27759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C6F")]
		[Address(RVA = "0x14268DC", Offset = "0x14268DC", VA = "0x7BBBC268DC")]
		public void ResetBanner()
		{
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C70")]
		[Address(RVA = "0x142696C", Offset = "0x142696C", VA = "0x7BBBC2696C")]
		public void ResetHeadPic()
		{
		}

		// Token: 0x06006C71 RID: 27761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C71")]
		[Address(RVA = "0x14269FC", Offset = "0x14269FC", VA = "0x7BBBC269FC")]
		public void ResetPin()
		{
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C72")]
		[Address(RVA = "0x1426A58", Offset = "0x1426A58", VA = "0x7BBBC26A58")]
		public void ShowClanName(bool v)
		{
		}

		// Token: 0x06006C73 RID: 27763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C73")]
		[Address(RVA = "0x1426AB8", Offset = "0x1426AB8", VA = "0x7BBBC26AB8")]
		public void ShowOnlineStatus(bool v)
		{
		}

		// Token: 0x06006C74 RID: 27764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C74")]
		[Address(RVA = "0x1426B18", Offset = "0x1426B18", VA = "0x7BBBC26B18")]
		public void ShowRank(bool v)
		{
		}

		// Token: 0x06006C75 RID: 27765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C75")]
		[Address(RVA = "0x1426B78", Offset = "0x1426B78", VA = "0x7BBBC26B78")]
		public void ShowInfoContainer(bool v)
		{
		}

		// Token: 0x06006C76 RID: 27766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C76")]
		[Address(RVA = "0x1426BC0", Offset = "0x1426BC0", VA = "0x7BBBC26BC0")]
		public void OnHeadBtnClick()
		{
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C77")]
		[Address(RVA = "0x14263F8", Offset = "0x14263F8", VA = "0x7BBBC263F8")]
		public void UpdateScrollText()
		{
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C78")]
		[Address(RVA = "0x1426130", Offset = "0x1426130", VA = "0x7BBBC26130")]
		public void UpdateRank(int rank, float rankPoint)
		{
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C79")]
		[Address(RVA = "0x1426248", Offset = "0x1426248", VA = "0x7BBBC26248")]
		public void UpdateRank(BaseProfileInfo data)
		{
		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C7A")]
		[Address(RVA = "0x1426CB8", Offset = "0x1426CB8", VA = "0x7BBBC26CB8")]
		public void ShowLadderRankChangeEffect()
		{
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C7B")]
		[Address(RVA = "0x1426D30", Offset = "0x1426D30", VA = "0x7BBBC26D30")]
		public UIBaseProfileInfoController()
		{
		}

		// Token: 0x04008812 RID: 34834
		[Token(Token = "0x4008812")]
		[FieldOffset(Offset = "0x58")]
		private UIBaseProfileInfoView m_View;

		// Token: 0x04008813 RID: 34835
		[Token(Token = "0x4008813")]
		[FieldOffset(Offset = "0x60")]
		public Action BtnCallBack;

		// Token: 0x04008814 RID: 34836
		[Token(Token = "0x4008814")]
		private const uint NIKENAME_GREY_COLOR = 2341178367U;

		// Token: 0x04008815 RID: 34837
		[Token(Token = "0x4008815")]
		[FieldOffset(Offset = "0x68")]
		private BaseItemInfo m_PinItemInfo;

		// Token: 0x04008816 RID: 34838
		[Token(Token = "0x4008816")]
		[FieldOffset(Offset = "0x70")]
		private GameObject[] m_CSStarArray;

		// Token: 0x04008817 RID: 34839
		[Token(Token = "0x4008817")]
		[FieldOffset(Offset = "0x78")]
		private GameObject[] m_CSBlackStarArray;

		// Token: 0x04008818 RID: 34840
		[Token(Token = "0x4008818")]
		[FieldOffset(Offset = "0x80")]
		private ESocial.Gender m_Gender;
	}
}
