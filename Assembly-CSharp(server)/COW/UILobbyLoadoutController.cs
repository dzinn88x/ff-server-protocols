using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A06 RID: 6662
	[Token(Token = "0x2001A06")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F76FC", Offset = "0x10F76FC")]
	public class UILobbyLoadoutController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008A9F RID: 35487 RVA: 0x000252F0 File Offset: 0x000234F0
		[Token(Token = "0x6008A9F")]
		[Address(RVA = "0x1440764", Offset = "0x1440764", VA = "0x7BBBC40764")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008AA0 RID: 35488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AA0")]
		[Address(RVA = "0x14407B4", Offset = "0x14407B4", VA = "0x7BBBC407B4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AA1")]
		[Address(RVA = "0x1440E1C", Offset = "0x1440E1C", VA = "0x7BBBC40E1C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008AA2 RID: 35490 RVA: 0x00025308 File Offset: 0x00023508
		[Token(Token = "0x6008AA2")]
		[Address(RVA = "0x1440F74", Offset = "0x1440F74", VA = "0x7BBBC40F74", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008AA3 RID: 35491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AA3")]
		[Address(RVA = "0x1440FD8", Offset = "0x1440FD8", VA = "0x7BBBC40FD8", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008AA4 RID: 35492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AA4")]
		[Address(RVA = "0x1441108", Offset = "0x1441108", VA = "0x7BBBC41108")]
		private void OnLoadOutBtnClick()
		{
		}

		// Token: 0x06008AA5 RID: 35493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AA5")]
		[Address(RVA = "0x1440A2C", Offset = "0x1440A2C", VA = "0x7BBBC40A2C")]
		private void UpdateLoadOuts(bool isLoadoutEquipped = false, bool isForced = false)
		{
		}

		// Token: 0x06008AA6 RID: 35494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AA6")]
		[Address(RVA = "0x14415E0", Offset = "0x14415E0", VA = "0x7BBBC415E0")]
		private void OnLoadOutSelected(params object[] data)
		{
		}

		// Token: 0x06008AA7 RID: 35495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AA7")]
		[Address(RVA = "0x144154C", Offset = "0x144154C", VA = "0x7BBBC4154C")]
		private void ProcessLoadOutSprite(UISprite noloadout, UISprite loadout, bool isEquipped)
		{
		}

		// Token: 0x06008AA8 RID: 35496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AA8")]
		[Address(RVA = "0x1441684", Offset = "0x1441684", VA = "0x7BBBC41684")]
		public UILobbyLoadoutController()
		{
		}

		// Token: 0x04009806 RID: 38918
		[Token(Token = "0x4009806")]
		[FieldOffset(Offset = "0x58")]
		private UIModelAvatarProfile m_AvatarProfileModel;

		// Token: 0x04009807 RID: 38919
		[Token(Token = "0x4009807")]
		[FieldOffset(Offset = "0x60")]
		private UILobbyLoadoutView m_View;

		// Token: 0x04009808 RID: 38920
		[Token(Token = "0x4009808")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsOldEquipped;

		// Token: 0x04009809 RID: 38921
		[Token(Token = "0x4009809")]
		[FieldOffset(Offset = "0x69")]
		private bool m_IsNewEquipped;

		// Token: 0x0400980A RID: 38922
		[Token(Token = "0x400980A")]
		[FieldOffset(Offset = "0x6A")]
		private bool m_IsSkillEquipped;
	}
}
