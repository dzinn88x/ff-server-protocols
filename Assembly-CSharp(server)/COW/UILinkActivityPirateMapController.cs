using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001549 RID: 5449
	[Token(Token = "0x2001549")]
	public class UILinkActivityPirateMapController : UILinkActivityDetailController
	{
		// Token: 0x06005E36 RID: 24118 RVA: 0x0001B4F8 File Offset: 0x000196F8
		[Token(Token = "0x6005E36")]
		[Address(RVA = "0x1CC1354", Offset = "0x1CC1354", VA = "0x7BBC4C1354")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E37")]
		[Address(RVA = "0x1CC13A4", Offset = "0x1CC13A4", VA = "0x7BBC4C13A4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E38")]
		[Address(RVA = "0x1CC14CC", Offset = "0x1CC14CC", VA = "0x7BBC4C14CC", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E39")]
		[Address(RVA = "0x1CC1518", Offset = "0x1CC1518", VA = "0x7BBC4C1518", Slot = "30")]
		protected override void InitActivityInfo()
		{
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3A")]
		[Address(RVA = "0x1CC17F0", Offset = "0x1CC17F0", VA = "0x7BBC4C17F0")]
		private void InitActivityInfo(LinkActivityData data)
		{
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3B")]
		[Address(RVA = "0x1CC1B58", Offset = "0x1CC1B58", VA = "0x7BBC4C1B58")]
		private void InitPirateInfo(LinkActivityMapData data)
		{
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3C")]
		[Address(RVA = "0x1CC1BE0", Offset = "0x1CC1BE0", VA = "0x7BBC4C1BE0")]
		public UILinkActivityPirateMapController()
		{
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3D")]
		[Address(RVA = "0x1CC1BF4", Offset = "0x1CC1BF4", VA = "0x7BBC4C1BF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FB1C", Offset = "0x113FB1C")]
		private void <InitActivityInfo>b__6_0(Texture tex)
		{
		}

		// Token: 0x04007F94 RID: 32660
		[Token(Token = "0x4007F94")]
		[FieldOffset(Offset = "0x70")]
		private UILinkActivityPirateMapView m_View;

		// Token: 0x04007F95 RID: 32661
		[Token(Token = "0x4007F95")]
		[FieldOffset(Offset = "0x78")]
		private List<UILinkActivityPirateMapRewardItemController> m_DailyAwardControllers;
	}
}
