using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02001034 RID: 4148
	[Token(Token = "0x2001034")]
	internal class UIModelManager : SingletonModule<UIModelManager>
	{
		// Token: 0x06003EE0 RID: 16096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE0")]
		public T GetModel<T>() where T : UIBaseModel, new()
		{
			return null;
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE1")]
		[Address(RVA = "0x20301C0", Offset = "0x20301C0", VA = "0x7BBC8301C0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE2")]
		[Address(RVA = "0x20301C4", Offset = "0x20301C4", VA = "0x7BBC8301C4", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE3")]
		[Address(RVA = "0x2030560", Offset = "0x2030560", VA = "0x7BBC830560")]
		public void ClearCache()
		{
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE4")]
		[Address(RVA = "0x2030808", Offset = "0x2030808", VA = "0x7BBC830808")]
		public void LoginOffline()
		{
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE5")]
		[Address(RVA = "0x2030AA8", Offset = "0x2030AA8", VA = "0x7BBC830AA8")]
		public void UserLogin(params object[] data)
		{
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE6")]
		[Address(RVA = "0x2030D5C", Offset = "0x2030D5C", VA = "0x7BBC830D5C")]
		public void UserLogout(params object[] data)
		{
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x2031010", Offset = "0x2031010", VA = "0x7BBC831010")]
		public void SceneChange(params object[] data)
		{
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE8")]
		[Address(RVA = "0x2030474", Offset = "0x2030474", VA = "0x7BBC830474")]
		private IEnumerable<UIBaseModel> GetModels()
		{
			return null;
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EE9")]
		[Address(RVA = "0x20312C4", Offset = "0x20312C4", VA = "0x7BBC8312C4")]
		public UIModelManager()
		{
		}

		// Token: 0x04004F22 RID: 20258
		[Token(Token = "0x4004F22")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, UIBaseModel> m_UIModels;

		// Token: 0x04004F23 RID: 20259
		[Token(Token = "0x4004F23")]
		[FieldOffset(Offset = "0x20")]
		private List<UIBaseModel> m_ModelLists;
	}
}
