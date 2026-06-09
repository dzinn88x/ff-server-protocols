using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200186F RID: 6255
	[Token(Token = "0x200186F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4104", Offset = "0x10F4104")]
	public class UIHudAudioBucketsController : UIBaseController
	{
		// Token: 0x06007B6A RID: 31594 RVA: 0x00021F18 File Offset: 0x00020118
		[Token(Token = "0x6007B6A")]
		[Address(RVA = "0x18880F4", Offset = "0x18880F4", VA = "0x7BBC0880F4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B6B RID: 31595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B6B")]
		[Address(RVA = "0x1888144", Offset = "0x1888144", VA = "0x7BBC088144", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007B6C RID: 31596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B6C")]
		[Address(RVA = "0x18882C0", Offset = "0x18882C0", VA = "0x7BBC0882C0")]
		private void OnAudioDeubgToggle()
		{
		}

		// Token: 0x06007B6D RID: 31597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B6D")]
		[Address(RVA = "0x1888348", Offset = "0x1888348", VA = "0x7BBC088348")]
		public UIHudAudioBucketsController()
		{
		}

		// Token: 0x04008FE4 RID: 36836
		[Token(Token = "0x4008FE4")]
		[FieldOffset(Offset = "0x58")]
		private UIHudAudioBucketsView m_View;

		// Token: 0x04008FE5 RID: 36837
		[Token(Token = "0x4008FE5")]
		[FieldOffset(Offset = "0x60")]
		private GameObject m_SoundEffectInfoTemplate;

		// Token: 0x04008FE6 RID: 36838
		[Token(Token = "0x4008FE6")]
		[FieldOffset(Offset = "0x68")]
		private Queue<AudioDebugInfo> m_InfoPool;

		// Token: 0x04008FE7 RID: 36839
		[Token(Token = "0x4008FE7")]
		[FieldOffset(Offset = "0x70")]
		private List<AudioDebugInfo> m_InfoList;
	}
}
