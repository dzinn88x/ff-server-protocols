using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001547 RID: 5447
	[Token(Token = "0x2001547")]
	internal class UILinkActivityFoxToriiController : UILinkActivityDetailController
	{
		// Token: 0x06005E29 RID: 24105 RVA: 0x0001B4C8 File Offset: 0x000196C8
		[Token(Token = "0x6005E29")]
		[Address(RVA = "0x1CBC308", Offset = "0x1CBC308", VA = "0x7BBC4BC308")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2A")]
		[Address(RVA = "0x1CBC358", Offset = "0x1CBC358", VA = "0x7BBC4BC358", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2B")]
		[Address(RVA = "0x1CBC5C4", Offset = "0x1CBC5C4", VA = "0x7BBC4BC5C4", Slot = "30")]
		protected override void InitActivityInfo()
		{
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2C")]
		[Address(RVA = "0x1CBC8A4", Offset = "0x1CBC8A4", VA = "0x7BBC4BC8A4")]
		private void InitActivityInfo(LinkActivityData data)
		{
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2D")]
		[Address(RVA = "0x1CBCE94", Offset = "0x1CBCE94", VA = "0x7BBC4BCE94")]
		private void InitProgressBar(UIProgressBar progressBar)
		{
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2E")]
		[Address(RVA = "0x1CBCD44", Offset = "0x1CBCD44", VA = "0x7BBC4BCD44")]
		private void InitLinkActivityInfo(LinkActivityMapData data)
		{
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2F")]
		[Address(RVA = "0x1CBD150", Offset = "0x1CBD150", VA = "0x7BBC4BD150")]
		private void OnZoomInButtonClick()
		{
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E30")]
		[Address(RVA = "0x1CBD194", Offset = "0x1CBD194", VA = "0x7BBC4BD194")]
		private void OnZoomOutButtonClick()
		{
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E31")]
		[Address(RVA = "0x1CBCF14", Offset = "0x1CBCF14", VA = "0x7BBC4BCF14")]
		private void InitBigMapTexture(uint mapID)
		{
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E32")]
		[Address(RVA = "0x1CBD1D8", Offset = "0x1CBD1D8", VA = "0x7BBC4BD1D8")]
		private string GetMiniMapName(uint map_id, string lang)
		{
			return null;
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E33")]
		[Address(RVA = "0x1CBD68C", Offset = "0x1CBD68C", VA = "0x7BBC4BD68C")]
		public UILinkActivityFoxToriiController()
		{
		}

		// Token: 0x04007F91 RID: 32657
		[Token(Token = "0x4007F91")]
		[FieldOffset(Offset = "0x70")]
		private UILinkActivityFoxToriiView m_View;

		// Token: 0x04007F92 RID: 32658
		[Token(Token = "0x4007F92")]
		[FieldOffset(Offset = "0x78")]
		private List<UILinkActivityFoxToriiRewardItemController> m_DailyAwardControllers;

		// Token: 0x04007F93 RID: 32659
		[Token(Token = "0x4007F93")]
		[FieldOffset(Offset = "0x80")]
		private LinkActivityMapData m_ActivityMapData;
	}
}
