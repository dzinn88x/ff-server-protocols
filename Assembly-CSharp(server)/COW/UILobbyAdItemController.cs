using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019E9 RID: 6633
	[Token(Token = "0x20019E9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F73E4", Offset = "0x10F73E4")]
	internal class UILobbyAdItemController : UIBaseController
	{
		// Token: 0x06008939 RID: 35129 RVA: 0x00024E28 File Offset: 0x00023028
		[Token(Token = "0x6008939")]
		[Address(RVA = "0x152501C", Offset = "0x152501C", VA = "0x7BBBD2501C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600893A RID: 35130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600893A")]
		[Address(RVA = "0x152506C", Offset = "0x152506C", VA = "0x7BBBD2506C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600893B RID: 35131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600893B")]
		[Address(RVA = "0x1525188", Offset = "0x1525188", VA = "0x7BBBD25188")]
		public void RefreshUIData(UIModelLobbyAds.AdInfo info)
		{
		}

		// Token: 0x0600893C RID: 35132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600893C")]
		[Address(RVA = "0x152553C", Offset = "0x152553C", VA = "0x7BBBD2553C")]
		public UILobbyAdItemController()
		{
		}

		// Token: 0x0600893D RID: 35133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600893D")]
		[Address(RVA = "0x1525544", Offset = "0x1525544", VA = "0x7BBBD25544")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11438D8", Offset = "0x11438D8")]
		private void <RefreshUIData>b__5_0()
		{
		}

		// Token: 0x0400974F RID: 38735
		[Token(Token = "0x400974F")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyAdItemView m_View;

		// Token: 0x04009750 RID: 38736
		[Token(Token = "0x4009750")]
		[FieldOffset(Offset = "0x60")]
		public int AdIndex;

		// Token: 0x04009751 RID: 38737
		[Token(Token = "0x4009751")]
		[FieldOffset(Offset = "0x68")]
		private GameObject[] m_ImgObjects;
	}
}
