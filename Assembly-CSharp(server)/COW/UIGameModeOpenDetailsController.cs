using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200184C RID: 6220
	[Token(Token = "0x200184C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3BE4", Offset = "0x10F3BE4")]
	internal class UIGameModeOpenDetailsController : UIBaseController
	{
		// Token: 0x06007A09 RID: 31241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A09")]
		[Address(RVA = "0x20094F8", Offset = "0x20094F8", VA = "0x7BBC8094F8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A0A")]
		[Address(RVA = "0x2009500", Offset = "0x2009500", VA = "0x7BBC809500", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A0B")]
		[Address(RVA = "0x2009684", Offset = "0x2009684", VA = "0x7BBC809684", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007A0C RID: 31244 RVA: 0x00021918 File Offset: 0x0001FB18
		[Token(Token = "0x6007A0C")]
		[Address(RVA = "0x2009750", Offset = "0x2009750", VA = "0x7BBC809750")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007A0D RID: 31245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A0D")]
		[Address(RVA = "0x1FFD070", Offset = "0x1FFD070", VA = "0x7BBC7FD070")]
		public void SetUIData(MapModeData mapModeData)
		{
		}

		// Token: 0x06007A0E RID: 31246 RVA: 0x00021930 File Offset: 0x0001FB30
		[Token(Token = "0x6007A0E")]
		[Address(RVA = "0x20097A0", Offset = "0x20097A0", VA = "0x7BBC8097A0")]
		private Color GetTagColor(EMapTag tag)
		{
			return default(Color);
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A0F")]
		[Address(RVA = "0x20097C0", Offset = "0x20097C0", VA = "0x7BBC8097C0")]
		private void SetOpenTimeUI(params object[] data)
		{
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A10")]
		[Address(RVA = "0x2009A2C", Offset = "0x2009A2C", VA = "0x7BBC809A2C")]
		public UIGameModeOpenDetailsController()
		{
		}

		// Token: 0x04008F08 RID: 36616
		[Token(Token = "0x4008F08")]
		[FieldOffset(Offset = "0x58")]
		private UIGameModeOpenDetailsView m_View;

		// Token: 0x04008F09 RID: 36617
		[Token(Token = "0x4008F09")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 m_DefaultOpenPos;

		// Token: 0x04008F0A RID: 36618
		[Token(Token = "0x4008F0A")]
		[FieldOffset(Offset = "0x70")]
		private MapModeData m_SelectedMapData;

		// Token: 0x04008F0B RID: 36619
		[Token(Token = "0x4008F0B")]
		[FieldOffset(Offset = "0x78")]
		private UIModelMapOpeningInfo m_ModelMap;
	}
}
