using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02001014 RID: 4116
	[Token(Token = "0x2001014")]
	public abstract class UIBaseModel
	{
		// Token: 0x06003DE6 RID: 15846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE6")]
		[Address(RVA = "0x2022D08", Offset = "0x2022D08", VA = "0x7BBC822D08", Slot = "4")]
		public virtual void Init()
		{
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE7")]
		[Address(RVA = "0x2022D0C", Offset = "0x2022D0C", VA = "0x7BBC822D0C")]
		public void RegisterDataChangedNotification(IUIModelDataChangeObserver observer)
		{
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE8")]
		[Address(RVA = "0x2022DE4", Offset = "0x2022DE4", VA = "0x7BBC822DE4")]
		public void UnRegisterDataChangedNotification(IUIModelDataChangeObserver observer)
		{
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE9")]
		[Address(RVA = "0x2022E58", Offset = "0x2022E58", VA = "0x7BBC822E58", Slot = "5")]
		public virtual void NotifyDataChanged(uint propID, params object[] param)
		{
		}

		// Token: 0x06003DEA RID: 15850
		[Token(Token = "0x6003DEA")]
		public abstract uint GetModelType();

		// Token: 0x06003DEB RID: 15851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEB")]
		[Address(RVA = "0x2023134", Offset = "0x2023134", VA = "0x7BBC823134", Slot = "7")]
		public virtual void LoginOffline()
		{
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEC")]
		[Address(RVA = "0x2023138", Offset = "0x2023138", VA = "0x7BBC823138", Slot = "8")]
		public virtual void Login(params object[] data)
		{
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DED")]
		[Address(RVA = "0x202313C", Offset = "0x202313C", VA = "0x7BBC82313C", Slot = "9")]
		public virtual void Logout(params object[] data)
		{
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEE")]
		[Address(RVA = "0x2023140", Offset = "0x2023140", VA = "0x7BBC823140", Slot = "10")]
		public virtual void SceneChange(params object[] data)
		{
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEF")]
		[Address(RVA = "0x202328C", Offset = "0x202328C", VA = "0x7BBC82328C")]
		public void Cleanup()
		{
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF0")]
		[Address(RVA = "0x202329C", Offset = "0x202329C", VA = "0x7BBC82329C", Slot = "11")]
		protected virtual void OnCleanup()
		{
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF1")]
		[Address(RVA = "0x20232A0", Offset = "0x20232A0", VA = "0x7BBC8232A0", Slot = "12")]
		protected virtual void OnSceneChange(params object[] data)
		{
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF2")]
		[Address(RVA = "0x20232A4", Offset = "0x20232A4", VA = "0x7BBC8232A4", Slot = "13")]
		public virtual void ClearCache()
		{
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF3")]
		[Address(RVA = "0x20232A8", Offset = "0x20232A8", VA = "0x7BBC8232A8")]
		protected UIBaseModel()
		{
		}

		// Token: 0x04004E82 RID: 20098
		[Token(Token = "0x4004E82")]
		[FieldOffset(Offset = "0x0")]
		public static bool ObserverCheck;

		// Token: 0x04004E83 RID: 20099
		[Token(Token = "0x4004E83")]
		[FieldOffset(Offset = "0x1")]
		public static bool SceneChangeCalledInLoadAndRun;

		// Token: 0x04004E84 RID: 20100
		[Token(Token = "0x4004E84")]
		[FieldOffset(Offset = "0x2")]
		public static bool SceneChangeRemoveUIObserver;

		// Token: 0x04004E85 RID: 20101
		[Token(Token = "0x4004E85")]
		[FieldOffset(Offset = "0x10")]
		private List<IUIModelDataChangeObserver> m_Observers;
	}
}
