using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200205F RID: 8287
	[Token(Token = "0x200205F")]
	public class PreviewParticleDataManager : SingletonModule<PreviewParticleDataManager>
	{
		// Token: 0x0600B891 RID: 47249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B891")]
		[Address(RVA = "0x174921C", Offset = "0x174921C", VA = "0x7BBBF4921C", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600B892 RID: 47250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B892")]
		[Address(RVA = "0x1749284", Offset = "0x1749284", VA = "0x7BBBF49284", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B893")]
		[Address(RVA = "0x17494E4", Offset = "0x17494E4", VA = "0x7BBBF494E4")]
		public PreviewParticleData FindPreviewParticleDataById(int InId)
		{
			return null;
		}

		// Token: 0x0600B894 RID: 47252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B894")]
		[Address(RVA = "0x174956C", Offset = "0x174956C", VA = "0x7BBBF4956C")]
		public PreviewParticleDataManager()
		{
		}

		// Token: 0x0400BA6F RID: 47727
		[Token(Token = "0x400BA6F")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, PreviewParticleData> m_dictIdToCSItemPreviewParticleData;
	}
}
