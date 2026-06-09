using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace COW
{
	// Token: 0x02001BF5 RID: 7157
	[Token(Token = "0x2001BF5")]
	public class VideoPlayController : MonoBehaviour
	{
		// Token: 0x06009B8A RID: 39818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B8A")]
		[Address(RVA = "0x179AD2C", Offset = "0x179AD2C", VA = "0x7BBBF9AD2C")]
		private void Awake()
		{
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B8B")]
		[Address(RVA = "0x179ADB4", Offset = "0x179ADB4", VA = "0x7BBBF9ADB4")]
		private void Start()
		{
		}

		// Token: 0x06009B8C RID: 39820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B8C")]
		[Address(RVA = "0x179B1EC", Offset = "0x179B1EC", VA = "0x7BBBF9B1EC")]
		private void SettingPlayOnUrl(string url)
		{
		}

		// Token: 0x06009B8D RID: 39821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B8D")]
		[Address(RVA = "0x179AFA4", Offset = "0x179AFA4", VA = "0x7BBBF9AFA4")]
		private void SettingPlayOnClip()
		{
		}

		// Token: 0x06009B8E RID: 39822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B8E")]
		[Address(RVA = "0x179B388", Offset = "0x179B388", VA = "0x7BBBF9B388")]
		private void OnDestroy()
		{
		}

		// Token: 0x06009B8F RID: 39823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B8F")]
		[Address(RVA = "0x179B4E8", Offset = "0x179B4E8", VA = "0x7BBBF9B4E8")]
		private void OnLocalPlayerEnter(params object[] data)
		{
		}

		// Token: 0x06009B90 RID: 39824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B90")]
		[Address(RVA = "0x179B6E8", Offset = "0x179B6E8", VA = "0x7BBBF9B6E8")]
		public VideoPlayController()
		{
		}

		// Token: 0x0400A1CF RID: 41423
		[Token(Token = "0x400A1CF")]
		[FieldOffset(Offset = "0x18")]
		private VideoPlayer videoPlayer;

		// Token: 0x0400A1D0 RID: 41424
		[Token(Token = "0x400A1D0")]
		[FieldOffset(Offset = "0x20")]
		private AudioSource audioSource;

		// Token: 0x0400A1D1 RID: 41425
		[Token(Token = "0x400A1D1")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hardwardSupport;

		// Token: 0x0400A1D2 RID: 41426
		[Token(Token = "0x400A1D2")]
		[FieldOffset(Offset = "0x29")]
		private bool m_canplay;
	}
}
