using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001695 RID: 5781
	[Token(Token = "0x2001695")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0614", Offset = "0x10F0614")]
	internal class UI2dCommonController : UIBaseController
	{
		// Token: 0x0600691C RID: 26908 RVA: 0x0001DC58 File Offset: 0x0001BE58
		[Token(Token = "0x600691C")]
		[Address(RVA = "0x1A35B84", Offset = "0x1A35B84", VA = "0x7BBC235B84")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600691D")]
		[Address(RVA = "0x1A35BD4", Offset = "0x1A35BD4", VA = "0x7BBC235BD4")]
		public void SetAnchorInspector(UIWidget item, GameObject go, int left, int right, int bottom, int top, float leftOri = 0f, float rightOri = 1f, float bottomOri = 0f, float topOri = 1f)
		{
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600691E")]
		[Address(RVA = "0x1A35DC4", Offset = "0x1A35DC4", VA = "0x7BBC235DC4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600691F")]
		[Address(RVA = "0x1A35E30", Offset = "0x1A35E30", VA = "0x7BBC235E30")]
		public void SetLeftAnchor(int biasLeft = 0, int biasRight = 0, int biasTop = 0, int biasBottom = 0)
		{
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006920")]
		[Address(RVA = "0x1A35EC0", Offset = "0x1A35EC0", VA = "0x7BBC235EC0")]
		public void SetRightAnchor()
		{
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006921")]
		[Address(RVA = "0x1A35EC8", Offset = "0x1A35EC8", VA = "0x7BBC235EC8")]
		public void SetCommonDepth(int depth)
		{
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006922")]
		[Address(RVA = "0x1A35F10", Offset = "0x1A35F10", VA = "0x7BBC235F10")]
		public void setUIdata(CSSharedItemData info, EFrontendUIType type)
		{
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006923")]
		[Address(RVA = "0x1A36E98", Offset = "0x1A36E98", VA = "0x7BBC236E98")]
		public void SetSpecialUIdata(BaseItemInfo data, EFrontendUIType type)
		{
		}

		// Token: 0x06006924 RID: 26916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006924")]
		[Address(RVA = "0x1A37020", Offset = "0x1A37020", VA = "0x7BBC237020")]
		private void SetSPSpriteWithInfo(BaseItemInfo itemInfo, UISprite iconSprite, bool isBigIcon = false)
		{
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006925")]
		[Address(RVA = "0x1A372FC", Offset = "0x1A372FC", VA = "0x7BBC2372FC")]
		public void SetUIItemViewPos(Vector3 tr)
		{
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006926")]
		[Address(RVA = "0x1A3737C", Offset = "0x1A3737C", VA = "0x7BBC23737C")]
		public void SetUIItemViewIconPos(Vector3 tr)
		{
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006927")]
		[Address(RVA = "0x1A373FC", Offset = "0x1A373FC", VA = "0x7BBC2373FC")]
		public void SetUIBannerViewPos(Vector3 tr)
		{
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006928")]
		[Address(RVA = "0x1A37464", Offset = "0x1A37464", VA = "0x7BBC237464")]
		public void SetUIHeadPicViewPos(Vector3 tr)
		{
		}

		// Token: 0x06006929 RID: 26921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006929")]
		[Address(RVA = "0x1A366E0", Offset = "0x1A366E0", VA = "0x7BBC2366E0")]
		private void SetSpriteWithInfo(CSSharedItemData itemInfo, UISprite iconSprite, bool isBigIcon = false)
		{
		}

		// Token: 0x0600692A RID: 26922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600692A")]
		[Address(RVA = "0x1A37918", Offset = "0x1A37918", VA = "0x7BBC237918")]
		private void SetSpriteWithInfo(params object[] data)
		{
		}

		// Token: 0x0600692B RID: 26923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600692B")]
		[Address(RVA = "0x1A374CC", Offset = "0x1A374CC", VA = "0x7BBC2374CC")]
		private void SetComposeIcon(UISprite iconSprite, UISprite sprite)
		{
		}

		// Token: 0x0600692C RID: 26924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600692C")]
		[Address(RVA = "0x1A37DE8", Offset = "0x1A37DE8", VA = "0x7BBC237DE8")]
		public UI2dCommonController()
		{
		}

		// Token: 0x04008628 RID: 34344
		[Token(Token = "0x4008628")]
		[FieldOffset(Offset = "0x58")]
		private UI2dItemView m_View;

		// Token: 0x04008629 RID: 34345
		[Token(Token = "0x4008629")]
		[FieldOffset(Offset = "0x60")]
		public bool left;
	}
}
