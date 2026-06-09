using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C99 RID: 7321
	[Token(Token = "0x2001C99")]
	internal class UIGlobalCOWImpl : UIGlobalFacadeInterface
	{
		// Token: 0x06009FBB RID: 40891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FBB")]
		[Address(RVA = "0x1A6E598", Offset = "0x1A6E598", VA = "0x7BBC26E598", Slot = "8")]
		public void CancelGameDelayCall(uint id)
		{
		}

		// Token: 0x06009FBC RID: 40892 RVA: 0x00029C10 File Offset: 0x00027E10
		[Token(Token = "0x6009FBC")]
		[Address(RVA = "0x1A6E61C", Offset = "0x1A6E61C", VA = "0x7BBC26E61C", Slot = "5")]
		public bool CheckIsInSpectatorSoundRange(Vector3 pos, uint resouceId)
		{
			return default(bool);
		}

		// Token: 0x06009FBD RID: 40893 RVA: 0x00029C28 File Offset: 0x00027E28
		[Token(Token = "0x6009FBD")]
		[Address(RVA = "0x1A6E624", Offset = "0x1A6E624", VA = "0x7BBC26E624", Slot = "7")]
		public uint GameDelayCall(float delayTime, Action action, bool isRepeated = false)
		{
			return 0U;
		}

		// Token: 0x06009FBE RID: 40894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FBE")]
		[Address(RVA = "0x1A6E6C8", Offset = "0x1A6E6C8", VA = "0x7BBC26E6C8", Slot = "4")]
		public void PlayButtonClickSound(string soundID)
		{
		}

		// Token: 0x06009FBF RID: 40895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FBF")]
		[Address(RVA = "0x1A6E84C", Offset = "0x1A6E84C", VA = "0x7BBC26E84C", Slot = "6")]
		public void SetNetworkTextureLoadingSprite(UISprite loadingSprite)
		{
		}

		// Token: 0x06009FC0 RID: 40896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FC0")]
		[Address(RVA = "0x1A6E970", Offset = "0x1A6E970", VA = "0x7BBC26E970")]
		public UIGlobalCOWImpl()
		{
		}

		// Token: 0x0400A67A RID: 42618
		[Token(Token = "0x400A67A")]
		private const string LOADING_SPRITENAME = "";
	}
}
