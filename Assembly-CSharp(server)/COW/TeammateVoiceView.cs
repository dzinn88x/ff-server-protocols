using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C29 RID: 7209
	[Token(Token = "0x2001C29")]
	public class TeammateVoiceView : MonoBehaviour
	{
		// Token: 0x06009CE1 RID: 40161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CE1")]
		[Address(RVA = "0x1B46E44", Offset = "0x1B46E44", VA = "0x7BBC346E44")]
		private void Awake()
		{
		}

		// Token: 0x06009CE2 RID: 40162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CE2")]
		[Address(RVA = "0x1B46F90", Offset = "0x1B46F90", VA = "0x7BBC346F90")]
		private void OnDestroy()
		{
		}

		// Token: 0x06009CE3 RID: 40163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CE3")]
		[Address(RVA = "0x1B4706C", Offset = "0x1B4706C", VA = "0x7BBC34706C")]
		public void Init(int team_index, ulong user_id, string nick_name)
		{
		}

		// Token: 0x06009CE4 RID: 40164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CE4")]
		[Address(RVA = "0x1B474A0", Offset = "0x1B474A0", VA = "0x7BBC3474A0")]
		public void UnInit()
		{
		}

		// Token: 0x06009CE5 RID: 40165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CE5")]
		[Address(RVA = "0x1B474F0", Offset = "0x1B474F0", VA = "0x7BBC3474F0")]
		private void OnMuteToggle()
		{
		}

		// Token: 0x06009CE6 RID: 40166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CE6")]
		[Address(RVA = "0x1B472D4", Offset = "0x1B472D4", VA = "0x7BBC3472D4")]
		private void RefreshView(params object[] data)
		{
		}

		// Token: 0x06009CE7 RID: 40167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CE7")]
		[Address(RVA = "0x1B475B0", Offset = "0x1B475B0", VA = "0x7BBC3475B0")]
		public TeammateVoiceView()
		{
		}

		// Token: 0x0400A2E0 RID: 41696
		[Token(Token = "0x400A2E0")]
		[FieldOffset(Offset = "0x18")]
		public UILabel IndexLabel;

		// Token: 0x0400A2E1 RID: 41697
		[Token(Token = "0x400A2E1")]
		[FieldOffset(Offset = "0x20")]
		public UILabel NameLabel;

		// Token: 0x0400A2E2 RID: 41698
		[Token(Token = "0x400A2E2")]
		[FieldOffset(Offset = "0x28")]
		public UIButton MuteToggleBtn;

		// Token: 0x0400A2E3 RID: 41699
		[Token(Token = "0x400A2E3")]
		[FieldOffset(Offset = "0x30")]
		public UISprite MutedSprite;

		// Token: 0x0400A2E4 RID: 41700
		[Token(Token = "0x400A2E4")]
		[FieldOffset(Offset = "0x38")]
		public UISprite NotMuteSprite;

		// Token: 0x0400A2E5 RID: 41701
		[Token(Token = "0x400A2E5")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 ViewSize;

		// Token: 0x0400A2E6 RID: 41702
		[Token(Token = "0x400A2E6")]
		[FieldOffset(Offset = "0x48")]
		private string Bind_UserID;
	}
}
