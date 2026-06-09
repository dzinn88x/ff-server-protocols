using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001038 RID: 4152
	[Token(Token = "0x2001038")]
	[Attribute(Name = "RequireComponent", RVA = "0x10EA85C", Offset = "0x10EA85C")]
	public class UINetworkTexture : MonoBehaviour
	{
		// Token: 0x06003F15 RID: 16149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F15")]
		[Address(RVA = "0x2032038", Offset = "0x2032038", VA = "0x7BBC832038")]
		public static implicit operator UITexture(UINetworkTexture network_texture)
		{
			return null;
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F16")]
		[Address(RVA = "0x2032060", Offset = "0x2032060", VA = "0x7BBC832060")]
		private void Awake()
		{
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F17")]
		[Address(RVA = "0x20320CC", Offset = "0x20320CC", VA = "0x7BBC8320CC")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F18")]
		[Address(RVA = "0x20321AC", Offset = "0x20321AC", VA = "0x7BBC8321AC")]
		public void UnRegisterCallBack()
		{
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F19")]
		[Address(RVA = "0x20321B4", Offset = "0x20321B4", VA = "0x7BBC8321B4", Slot = "4")]
		public virtual void SetAsyncImageFromUrl(string url, bool isMakePerfect = false, bool needCache = true, [Optional] Action successCallBack, bool useOriginalUrl = false, bool isReadable = false)
		{
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F1A")]
		[Address(RVA = "0x2032948", Offset = "0x2032948", VA = "0x7BBC832948", Slot = "5")]
		public virtual void OnDowloadFinished(Texture texture)
		{
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F1B")]
		[Address(RVA = "0x2032508", Offset = "0x2032508", VA = "0x7BBC832508")]
		private void LoadingSpriteActive(bool show)
		{
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F1C")]
		[Address(RVA = "0x2032AF0", Offset = "0x2032AF0", VA = "0x7BBC832AF0")]
		public UINetworkTexture()
		{
		}

		// Token: 0x04004F42 RID: 20290
		[Token(Token = "0x4004F42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UITexture m_TargetTexture;

		// Token: 0x04004F43 RID: 20291
		[Token(Token = "0x4004F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture m_DefaultTexture;

		// Token: 0x04004F44 RID: 20292
		[Token(Token = "0x4004F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UISprite LoadingSprite;

		// Token: 0x04004F45 RID: 20293
		[Token(Token = "0x4004F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private bool m_NeedSpinningWhenLoad;

		// Token: 0x04004F46 RID: 20294
		[Token(Token = "0x4004F46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool m_IsMakePerfect;

		// Token: 0x04004F47 RID: 20295
		[Token(Token = "0x4004F47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_CurrentDownloadURL;

		// Token: 0x04004F48 RID: 20296
		[Token(Token = "0x4004F48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_IsUseOriginalURL;

		// Token: 0x04004F49 RID: 20297
		[Token(Token = "0x4004F49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string LoadingSpritePath;

		// Token: 0x04004F4A RID: 20298
		[Token(Token = "0x4004F4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string LoadingSpriteName;

		// Token: 0x04004F4B RID: 20299
		[Token(Token = "0x4004F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool m_IsAwaked;

		// Token: 0x04004F4C RID: 20300
		[Token(Token = "0x4004F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool m_IsPendingDownload;

		// Token: 0x04004F4D RID: 20301
		[Token(Token = "0x4004F4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action m_SuccessCallBack;
	}
}
